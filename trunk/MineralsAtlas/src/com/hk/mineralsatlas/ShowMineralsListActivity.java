package com.hk.mineralsatlas;

import java.util.HashMap;

import android.app.ListActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView.AdapterContextMenuInfo;
import android.widget.Toast;

import com.hk.mineralsatlas.dao.LoadData;

public class ShowMineralsListActivity extends ListActivity {

	private static final String DATA_TYPE = "mineraly";
	private static final String GROUP = "nazovSkupina";
	private static final String NAME = "nazov";
	private static final String FORMULA = "chemickeZlozenie";
	private static final String ENTRY_ID = "id";
	private static final String[] COLUMNS_MINERALS_LIST = { GROUP, NAME,
			FORMULA, ENTRY_ID };
	private static final int[] COLUMN_IDS_MINERALS_LIST = { R.id.group,
			R.id.name, R.id.formula, R.id.entry_id };
	private static final String[] COLUMNS_LOCATIONS_LIST = { GROUP, NAME,
			FORMULA, ENTRY_ID };
	private static final int[] COLUMN_IDS_LICATIONS_LIST = { R.id.group,
			R.id.name, R.id.formula, R.id.entry_id };
	private static final int LAYOUT_ID = R.layout.single_data;
	private static final int MENU_GET_DETAILS = 0;
	private static final int MENU_GET_MAP = 1;
	private static String url;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.list_minerals);

		url = getIntent().getStringExtra(Constants.EXTRA_URL);
		String path = getIntent().getStringExtra(Constants.EXTRA_PATH);
		String actionID = getIntent().getStringExtra(Constants.EXTRA_ACTION);
		if (url.equals("") || path.equals("")) {
			Toast.makeText(this, R.string.no_url_found, Toast.LENGTH_LONG)
					.show();
			return;
		}
		LoadData dataProvider = new LoadData(this, url + path, DATA_TYPE,
				LAYOUT_ID, COLUMNS_MINERALS_LIST, COLUMN_IDS_MINERALS_LIST);

		dataProvider.execute();
		if (Constants.MINERALS_LIST.equals(actionID)) {
			registerForContextMenu(getListView());
		}

	}

	@Override
	public void onCreateContextMenu(ContextMenu menu, View v,
			ContextMenu.ContextMenuInfo menuInfo) {
		super.onCreateContextMenu(menu, v, menuInfo);
		menu.add(0, MENU_GET_DETAILS, 0, R.string.get_details);
		menu.add(0, MENU_GET_MAP, 0, R.string.get_map);

	}

	@Override
	@SuppressWarnings("unchecked")
	public boolean onContextItemSelected(MenuItem item) {

		AdapterContextMenuInfo info = (AdapterContextMenuInfo) item
				.getMenuInfo();

		HashMap<String, String> text = (HashMap<String, String>) this
				.getListView().getItemAtPosition((int) info.id);
		switch (item.getItemId()) {

		case MENU_GET_MAP:

			showExtra(text.get(ENTRY_ID));

			return true;

		case MENU_GET_DETAILS:

			showExtra(text.get(ENTRY_ID));

			return true;

		default:

			return super.onContextItemSelected(item);

		}

	}

	public void showDetailActivity(String actionId) {
		Intent i = new Intent(this, ShowMineralsDetailActivity.class);
		i.putExtra(Constants.EXTRA_URL, url);
		i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_MINERALS_DETAIL);
		startActivity(i);
	}

	public void showExtra(String actionId) {

		Intent i = new Intent(this, ShowMineralsExtraActivity.class);
		i.putExtra(Constants.EXTRA_ACTION, actionId);
		i.putExtra(Constants.EXTRA_URL, url);
		startActivity(i);
	}
}