package com.hk.queenb;

import android.app.ListActivity;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.support.v4.widget.SimpleCursorAdapter;
import android.view.ContextMenu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView.AdapterContextMenuInfo;
import android.widget.LinearLayout;
import android.widget.ListAdapter;
import android.widget.Toast;

import com.google.ads.AdRequest;
import com.google.ads.AdSize;
import com.google.ads.AdView;
import com.hk.queenb.dao.SqliteDao;

public class QueensList extends ListActivity {

	private static final int MENU_DETAIL_ID = 0;
	private static final int MENU_DELETE_ID = 1;
	private AdView av;

	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.data_container);
		registerForContextMenu(getListView());
		updateList();
		av = new AdView(this, AdSize.SMART_BANNER, "a15167e41a49a63");
		// Lookup your LinearLayout assuming it’s been given
		// the attribute android:id="@+id/mainLayout"
		LinearLayout layout = (LinearLayout) findViewById(R.id.mainLayout);
		// Add the adView to it
		layout.addView(av);
		// Initiate a generic request to load it with an ad
		av.loadAd(new AdRequest());
	}

	public void updateList() {
		Context ctx = this;
		SqliteDao SqliteDao = new SqliteDao(ctx);
		if (!SqliteDao.existsRecord())
			return;
		String[] from = { SqliteDao.COLUMN_DATE, SqliteDao.COLUMN_NOTE };
		int[] to = { android.R.id.text2, android.R.id.text1 };

		ListAdapter adapter = new SimpleCursorAdapter(ctx,
				android.R.layout.simple_list_item_2, SqliteDao.getDates2(),
				from, to, 0);

		setListAdapter(adapter);

		SqliteDao.close();
	}

	@Override
	public void onCreateContextMenu(ContextMenu menu, View v,
			ContextMenu.ContextMenuInfo menuInfo) {
		super.onCreateContextMenu(menu, v, menuInfo);
		menu.add(0, MENU_DETAIL_ID, 0, R.string.detail);
		menu.add(0, MENU_DELETE_ID, 1, R.string.delete);
	}

	@Override
	public boolean onContextItemSelected(MenuItem item) {
		AdapterContextMenuInfo info = (AdapterContextMenuInfo) item
				.getMenuInfo();

		switch (item.getItemId()) {
		case MENU_DETAIL_ID:
			showDate(info.id);
			return true;

		case MENU_DELETE_ID:
			deleteDate(info.id);
			return true;
		default:
			return super.onContextItemSelected(item);
		}
	}

	private void deleteDate(long id) {
		Context ctx = this;
		SqliteDao SqliteDao = new SqliteDao(ctx);

		if (SqliteDao.deleteDate(id, this)) {
			Toast.makeText(ctx, R.string.date_deleted, Toast.LENGTH_SHORT)
					.show();
			updateList();
		} else {
			Toast.makeText(ctx, R.string.date_not_deleted, Toast.LENGTH_SHORT)
					.show();
		}
		SqliteDao.close();
	}

	private void showDate(Long id) {
		Intent i = new Intent(this, NewQueen.class);
		Context ctx = this;
		SqliteDao SqliteDao = new SqliteDao(ctx);
		Cursor date = SqliteDao.getDate(id);
		String dateText = "";
		String noteText = "";
		int dateIndex = date.getColumnIndex(SqliteDao.COLUMN_DATE);
		int noteIndex = date.getColumnIndex(SqliteDao.COLUMN_NOTE);

		if (date.getCount() < 1) {
			Toast.makeText(ctx, R.string.date_not_found, Toast.LENGTH_SHORT)
					.show();
			return;
		} else {
			date.moveToNext();
			dateText = date.getString(dateIndex);
			noteText = date.getString(noteIndex);
		}

		date.close();
		SqliteDao.close();
		i.putExtra(Constants.DATE, dateText);
		i.putExtra(Constants.NOTE, noteText);
		startActivity(i);

	}

	@Override
	public void onDestroy() {
		if (av != null) {
			av.destroy();
		}
		super.onDestroy();
	}

}
