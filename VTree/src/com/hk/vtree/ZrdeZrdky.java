package com.hk.vtree;

import android.os.Bundle;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class ZrdeZrdky extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_zrde_zrdky);
		
		
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.zrde_zrdky, menu);
		return true;
	}
	
	
	public void onClickButtonPokus( View v){
		
		TextView objemik = (TextView) findViewById(R.id.textViewIhlZrde1);
		objemik.setText(vypocty.tester());
		Toast.makeText(this, "pokus - tester",Toast.LENGTH_LONG).show();
		
		
		
	}
	
	
	
	

}
