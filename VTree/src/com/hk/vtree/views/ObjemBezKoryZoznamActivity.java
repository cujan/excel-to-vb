package com.hk.vtree.views;

import android.app.ListActivity;
import android.content.Context;
import android.os.Bundle;
import android.support.v4.widget.SimpleCursorAdapter;
import android.view.Menu;
import android.widget.ListAdapter;

import com.hk.vtree.R;
import com.hk.vtree.dao.DatabaseHelper;
import com.hk.vtree.dao.MeraniaDao;
import com.hk.vtree.dao.stlpce.MeraniaStlpce;

public class ObjemBezKoryZoznamActivity extends ListActivity {

	private DatabaseHelper mDbHelper;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.objem_bez_kory_zoznam);
		updateList();
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_objem_bez_kory_zoznam, menu);
		return true;
	}

	public void updateList() {

		initializeDbHelper(this);

		int[] to = { android.R.id.text2, android.R.id.text1 };
		String[] from = { MeraniaDao._ID, MeraniaStlpce.NAZOV };
		ListAdapter adapter = new SimpleCursorAdapter(this,
				android.R.layout.simple_list_item_2,
				MeraniaDao.dajMerania(mDbHelper), from, to, 0);

		setListAdapter(adapter);
		registerForContextMenu(getListView());
	}

	private void initializeDbHelper(Context context) {
		if (this.mDbHelper == null) {
			this.mDbHelper = new DatabaseHelper(context);
		}
	}

}
