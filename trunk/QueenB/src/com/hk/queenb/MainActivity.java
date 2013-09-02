package com.hk.queenb;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Typeface;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.TextView;

import com.google.analytics.tracking.android.EasyTracker;

public class MainActivity extends FragmentActivity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);		
		setContentView(R.layout.single_column_main);

		TextView titleText = (TextView) this.findViewById(R.id.title_text);
		Button novyChov = (Button) this.findViewById(R.id.novy_chov);
		Button zoznamChovov = (Button) this.findViewById(R.id.zoznam_chovov);
		Button oPrograme = (Button) this.findViewById(R.id.o_programe);
		Typeface font = Typeface
				.createFromAsset(getAssets(), "kristen-itc.ttf");
		titleText.setTypeface(font);
		novyChov.setTypeface(font);
		zoznamChovov.setTypeface(font);
		oPrograme.setTypeface(font);

		// dualPane = findViewById(R.id.right_column) != null;
		// PreferenceManager.getDefaultSharedPreferences(this);
	}

	@Override
	public void onStart() {
		super.onStart();
		EasyTracker.getInstance().activityStart(this); // Add this method.
	}

	@Override
	public void onStop() {
		super.onStop();
		EasyTracker.getInstance().activityStop(this); // Add this method.
	}

	public void onVytvorNovyChov(View v) {
		Intent i = new Intent(MainActivity.this, NewQueen.class);
		startActivity(i);
	}

	public void onOPrograme(View v) {
		// Use the Builder class for convenient dialog construction
		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setMessage(R.string.popis_programu).setPositiveButton(
				R.string.ok, new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int id) {
						// FIRE ZE MISSILES!
					}
				});
		// Create the AlertDialog object and return it
		builder.create();
		builder.show();
	}

	public void onZoznamChovov(View v) {
		Intent i = new Intent(MainActivity.this, QueensList.class);
		startActivity(i);
	}

}
