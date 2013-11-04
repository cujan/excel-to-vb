package com.hk.vtree;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

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

}
