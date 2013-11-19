package com.hk.vtree.views;

import com.hk.vtree.R;
import com.hk.vtree.R.layout;
import com.hk.vtree.R.menu;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;

public class ObjemBezKoryMainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.objem_bez_kory_menu);
	}
	
	public void onClickObkNove(View v){
		Intent i = new Intent(this, ObjemBezKoryNovy.class);
		startActivity(i);
		}
	
	public void onClickObkZoznam(View v){
		Intent i = new Intent(this, ObjemBezKoryZoznamActivity.class);
		startActivity(i);
		}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_objem_bez_kory_menu, menu);
		return true;
	}

}
