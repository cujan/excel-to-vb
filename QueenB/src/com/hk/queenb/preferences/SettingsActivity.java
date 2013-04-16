package com.hk.queenb.preferences;

import android.os.Bundle;

import com.hk.queenb.R;

@SuppressWarnings("deprecation")
public class SettingsActivity extends android.preference.PreferenceActivity {

	public static final String REMOTE_URL = "remote_url";

	@Override
	protected void onCreate(Bundle icicle) {
		super.onCreate(icicle);
		addPreferencesFromResource(R.xml.settings);
	}

	// public static String getRemoteUrl(Context ctx) {
	// return PreferenceManager.getDefaultSharedPreferences(ctx).getString(
	// REMOTE_URL, "");
	// }

}
