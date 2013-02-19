package com.hk.mineralsatlas;

import android.app.ListActivity;
import android.os.Bundle;
import android.widget.Toast;

import com.hk.mineralsatlas.dao.LoadData;

public class ShowMineralsDetailActivity extends ListActivity {

	private static final int LAYOUT_ID = R.layout.minerals_detail;
	private static String url;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.detail_minerals);

		url = getIntent().getStringExtra(Constants.EXTRA_URL);
		String path = getIntent().getStringExtra(Constants.EXTRA_PATH);
		String key = getIntent().getStringExtra(Constants.EXTRA_ACTION_KEY);
		if (url.equals("") || path.equals("")) {
			Toast.makeText(this, R.string.no_url_found, Toast.LENGTH_LONG)
					.show();
			return;
		}
		LoadData dataProvider = new LoadData(this, url + path + key,
				Constants.MINERALS_DETAIL_DATA_TYPE, LAYOUT_ID,
				Constants.COLUMNS_MINERALS_DETAIL,
				Constants.COLUMN_IDS_MINERALS_DETAIL);

		dataProvider.execute();
		registerForContextMenu(getListView());

	}
}