package com.hk.mineralsatlas;

import android.app.ListActivity;
import android.os.Bundle;
import android.widget.Toast;

import com.hk.mineralsatlas.dao.LoadData;


public class ShowMineralsDetailActivity extends ListActivity {

	private static final String DATA_TYPE = "mineraly";
	private static final String GROUP = "nazovSkupina";
	private static final String NAME = "nazov";
	private static final String FORMULA = "chemickeZlozenie";
	private static final String ENTRY_ID = "id";
	private static final String[] COLUMNS = { GROUP, NAME, FORMULA, ENTRY_ID };
	private static final int[] COLUMN_IDS = { R.id.group, R.id.name, R.id.formula, R.id.entry_id };
	private static final int LAYOUT_ID = R.layout.single_data;
	private static String url;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.detail_minerals);

		url = getIntent().getStringExtra(Constants.EXTRA_URL);
		String path = getIntent().getStringExtra(Constants.EXTRA_PATH);
		if (url.equals("") || path.equals("")) {
			Toast.makeText(this, R.string.no_url_found,
					Toast.LENGTH_LONG).show();
			return;
		}
		LoadData dataProvider = new LoadData(this, url + path, DATA_TYPE,
				LAYOUT_ID, COLUMNS, COLUMN_IDS);

		dataProvider.execute();
		registerForContextMenu(getListView());

	}
}