package com.hk.mineralsatlas.preferences;

import android.content.Context;
import android.os.Bundle;
import android.preference.PreferenceManager;

import com.hk.mineralsatlas.R;

@SuppressWarnings("deprecation")
public class SettingsActivity extends android.preference.PreferenceActivity {

	public static final String REMOTE_URL = "remote_url";


	@Override
	protected void onCreate(Bundle icicle) {
		super.onCreate(icicle);
		addPreferencesFromResource(R.xml.settings);
	}

	public static String getRemoteUrl(Context ctx) {
		return PreferenceManager.getDefaultSharedPreferences(ctx).getString(
				REMOTE_URL, "");
	}
	

}
