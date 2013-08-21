package com.hk.woodenchurches;

import android.os.Bundle;
import android.text.Html;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.actionbarsherlock.app.SherlockFragment;

public class ChurchHistory extends SherlockFragment {

	public View onCreateView(LayoutInflater inflater, ViewGroup container,
			Bundle savedInstanceState) {
		View root = inflater.inflate(R.layout.church_history, container, false);

		TextView tv = (TextView) root.findViewById(R.id.text);
		tv.setText(Html.fromHtml(getString(R.string.church_history_text)));
		return root;
	}
}
