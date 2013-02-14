package com.hk.mineralsatlas;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.v4.app.FragmentActivity;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;

import com.hk.mineralsatlas.preferences.SettingsActivity;

public class MainActivity extends FragmentActivity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.single_column_main);
		// dualPane = findViewById(R.id.right_column) != null;

		PreferenceManager.getDefaultSharedPreferences(this);
	}

	public void onShowMineralsClicked(View v) {
		getCorrectURLFromView(Constants.MINERALS_LIST);
	}

	public void onShowLocationsClicked(View v) {
		getCorrectURLFromView(Constants.LOCATIONS_LIST);
	}

	private void getCorrectURLFromView(String actionType) {
		String url = formatURL(SettingsActivity.getRemoteUrl(MainActivity.this));

		if (actionType.equals(Constants.MINERALS_LIST)) {
			Intent i = new Intent(MainActivity.this,
					ShowMineralsListActivity.class);
			i.putExtra(Constants.EXTRA_URL, url);
			i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_MINERALS_LIST);
			i.putExtra(Constants.EXTRA_ACTION, Constants.MINERALS_LIST);
			startActivity(i);
		} else if (actionType.equals(Constants.LOCATIONS_LIST)) {
			Intent i = new Intent(MainActivity.this,
					ShowMineralsListActivity.class);
			i.putExtra(Constants.EXTRA_URL, url);
			i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_LOCATIONS_LIST);
			i.putExtra(Constants.EXTRA_ACTION, Constants.LOCATIONS_LIST);
			startActivity(i);
		} else {
			showExtra(actionType, url, MainActivity.this);
		}
	}

	public String formatURL(String url) {
		int urlLength = url.length();
		if (urlLength < 1)
			return "";
		char end = url.charAt(urlLength - 1);
		char beginning = url.charAt(0);		
		url = (beginning != 'h' ? "http://" + url : url );		
		return (end != '/' ? url + "/" : url);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		MenuInflater inflater = getMenuInflater();
		inflater.inflate(R.menu.options_menu, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		Intent i;
		switch (item.getItemId()) {
		case R.id.settings:
			i = new Intent(this, SettingsActivity.class);
			startActivity(i);
			return true;
		default:
			return super.onOptionsItemSelected(item);
		}
	}

	public void showExtra(String actionId, String url, Context ctx) {

		Intent i = new Intent(ctx, ShowMineralsExtraActivity.class);
		i.putExtra(Constants.EXTRA_ACTION, actionId);
		i.putExtra(Constants.EXTRA_URL, url);
		startActivity(i);
	}

}
