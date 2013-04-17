package com.hk.queenb;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.View;

import com.google.analytics.tracking.android.EasyTracker;

public class MainActivity extends FragmentActivity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.single_column_main);
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

	public void onZoznamChovov(View v) {
		Intent i = new Intent(MainActivity.this, QueensList.class);
		startActivity(i);
	}

}
