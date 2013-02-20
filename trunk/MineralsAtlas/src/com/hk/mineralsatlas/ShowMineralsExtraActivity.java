package com.hk.mineralsatlas;

import android.annotation.SuppressLint;
import android.annotation.TargetApi;
import android.app.Activity;
import android.content.res.Resources;
import android.net.http.SslError;
import android.os.Build;
import android.os.Bundle;
import android.view.Window;
import android.webkit.SslErrorHandler;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Toast;

public class ShowMineralsExtraActivity extends Activity {

	@SuppressLint("SetJavaScriptEnabled")
	@Override
	public void onCreate(Bundle savedInstanceState) {
		getWindow().requestFeature(Window.FEATURE_PROGRESS);
		super.onCreate(savedInstanceState);
		setContentView(R.layout.web_layout);
		String path = getIntent().getStringExtra(Constants.EXTRA_PATH);
		String actionKey = getIntent().getStringExtra(
				Constants.EXTRA_ACTION_KEY);
		String url = getIntent().getStringExtra(Constants.EXTRA_URL);
		Resources res = getResources();
		// Imageview to show
		WebView web = (WebView) findViewById(R.id.web);

		// Let's display the progress in the activity title bar, like the
		// browser app does.

		WebSettings webSettings = web.getSettings();
		webSettings.setJavaScriptEnabled(true);
		webSettings.setBuiltInZoomControls(true);
		// web.setHttpAuthUsernamePassword(url, "",
		// SettingsActivity.getLogin(this), SettingsActivity.getPass(this));

		final Activity activity = this;

		web.setWebViewClient(new WebViewClient() {
			// @Override
			// public void onReceivedHttpAuthRequest(WebView view,
			// HttpAuthHandler handler, String host, String realm) {
			// handler.proceed(SettingsActivity
			// .getLogin(ShowMineralsExtraActivity.this),
			// SettingsActivity
			// .getPass(ShowMineralsExtraActivity.this));
			// }

			@Override
			@TargetApi(Build.VERSION_CODES.FROYO)
			public void onReceivedSslError(WebView view,
					SslErrorHandler handler, SslError error) {
				handler.proceed();
				// Toast.makeText(activity, "SSL Error " + error.toString(),
				// Toast.LENGTH_LONG).show();
			}

			@Override
			public void onReceivedError(WebView view, int errorCode,
					String description, String failingUrl) {
				Toast.makeText(activity, "Oh no! " + description,
						Toast.LENGTH_LONG).show();
			}
		});

		web.loadUrl(url + path + actionKey);

	}

}