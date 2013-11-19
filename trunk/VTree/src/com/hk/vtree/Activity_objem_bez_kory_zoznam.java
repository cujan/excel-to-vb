package com.hk.vtree;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;

public class Activity_objem_bez_kory_zoznam extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_activity_objem_bez_kory_zoznam);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_objem_bez_kory_zoznam, menu);
		return true;
	}

}
