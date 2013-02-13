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
	private static final String LOCATIONS_DATA_TYPE = "naleziska";
	private static final String GROUP = "nazovSkupina";
	private static final String NAME = "nazov";
	private static final String OKRES = "okres";
	private static final String GEOMORFOLOGICKY_CELOK = "geomorfologickyCelok";
	private static final String CHARAKTERISTIKA = "charakteristika";
	private static final String GEOLOGICKY_CELOK = "geologickyCelok";
	private static final String HORNINOVE_ZLOZENIE = "horninoveZlozenie";
	private static final String ZEMEPISNA_SIRKA = "zemepisnaSirka";
	private static final String ZEMEPISNA_DLZKA = "zemepisnaDlzka";
	private static final String MINERALY = "mineraly";
	private static final String FORMULA = "chemickeZlozenie";
	private static final String ENTRY_ID = "id";
	private static final String[] COLUMNS_MINERALS_LIST = { GROUP, NAME,
			FORMULA, ENTRY_ID };
	private static final int[] COLUMN_IDS_MINERALS_LIST = { R.id.group,
			R.id.name, R.id.formula, R.id.entry_id };
	private static final String[] COLUMNS_LOCATIONS_LIST = { NAME, OKRES,
			GEOMORFOLOGICKY_CELOK, GEOLOGICKY_CELOK, CHARAKTERISTIKA,
			HORNINOVE_ZLOZENIE, MINERALY, ZEMEPISNA_SIRKA, ZEMEPISNA_DLZKA,
			ENTRY_ID };
	private static final int[] COLUMN_IDS_LOCATIONS_LIST = { R.id.name,
			R.id.okres, R.id.geomorfologicky_celok, R.id.geologicky_celok,
			R.id.charakteristika, R.id.horninove_zlozenie, R.id.mineraly,
			R.id.zemepisna_sirka, R.id.zemepisna_dlzka, R.id.entry_id };
	private static final int LAYOUT_ID_MINERALS = R.layout.minerals_list;
	private static final int LAYOUT_ID_LOCATIONS = R.layout.locations_list;
	public static final int MENU_GET_DETAILS = 0;
	public static final int MENU_GET_PHOTO = 1;
	public static final int MENU_GET_LOCATION_ON_MAP = 2;

	private static String url;
	private String actionID;

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.list_minerals);

		url = getIntent().getStringExtra(Constants.EXTRA_URL);
		String path = getIntent().getStringExtra(Constants.EXTRA_PATH);
		actionID = getIntent().getStringExtra(Constants.EXTRA_ACTION);
		if (url.equals("") || path.equals("")) {
			Toast.makeText(this, R.string.no_url_found, Toast.LENGTH_LONG)
					.show();
			return;
		}
		LoadData dataProvider = new LoadData(null, actionID, actionID, 0, null,
				null);
		if (Constants.MINERALS_LIST.equals(actionID)) {
			dataProvider = new LoadData(this, url + path, DATA_TYPE,
					LAYOUT_ID_MINERALS, COLUMNS_MINERALS_LIST,
					COLUMN_IDS_MINERALS_LIST);
		} else if (Constants.LOCATIONS_LIST.equals(actionID)) {
			dataProvider = new LoadData(this, url + path, LOCATIONS_DATA_TYPE,
					LAYOUT_ID_LOCATIONS, COLUMNS_LOCATIONS_LIST,
					COLUMN_IDS_LOCATIONS_LIST);
		}
		dataProvider.execute();
		registerForContextMenu(getListView());
	}

	@Override
	public void onCreateContextMenu(ContextMenu menu, View v,
			ContextMenu.ContextMenuInfo menuInfo) {
		super.onCreateContextMenu(menu, v, menuInfo);
		if (Constants.MINERALS_LIST.equals(actionID)) {
			menu.add(0, MENU_GET_DETAILS, 0, R.string.get_details);
			menu.add(0, MENU_GET_PHOTO, 0, R.string.get_photo);
		} else if (Constants.LOCATIONS_LIST.equals(actionID)) {
			menu.add(0, MENU_GET_LOCATION_ON_MAP, 0, R.string.get_map);
		}
	}

	@Override
	@SuppressWarnings("unchecked")
	public boolean onContextItemSelected(MenuItem item) {

		AdapterContextMenuInfo info = (AdapterContextMenuInfo) item
				.getMenuInfo();

		HashMap<String, String> text = (HashMap<String, String>) this
				.getListView().getItemAtPosition((int) info.id);
		
		
		switch (item.getItemId()) {

		case MENU_GET_PHOTO:

			showExtra(text.get(ENTRY_ID), MENU_GET_PHOTO);

			return true;

		case MENU_GET_DETAILS:

			showDetailActivity(text.get(ENTRY_ID));

			return true;

		case MENU_GET_LOCATION_ON_MAP:

			showExtra(
					text.get(ZEMEPISNA_SIRKA).toString() + "," + text.get(ZEMEPISNA_DLZKA).toString(),
					MENU_GET_LOCATION_ON_MAP);

			return true;

		default:

			return super.onContextItemSelected(item);

		}

	}

	public void showDetailActivity(String actionKey) {
		Intent i = new Intent(this, ShowMineralsDetailActivity.class);
		i.putExtra(Constants.EXTRA_URL, url);
		i.putExtra(Constants.EXTRA_ACTION_KEY, actionKey);
		i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_MINERALS_DETAIL);
		startActivity(i);
	}

	public void showExtra(String actionKey, int menuID) {
		Intent i = new Intent(this, ShowMineralsExtraActivity.class);
		if (menuID == MENU_GET_LOCATION_ON_MAP) {
			i.putExtra(Constants.EXTRA_URL, "");
			i.putExtra(Constants.EXTRA_ACTION_KEY, actionKey);
			i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_MAP);
		} else if (menuID == MENU_GET_PHOTO) {
			i.putExtra(Constants.EXTRA_URL, url);
			i.putExtra(Constants.EXTRA_ACTION_KEY, actionKey);
			i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_PHOTOS);
		}
		startActivity(i);
	}
}