package com.hk.vtree.dao;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DatabaseHelper extends SQLiteOpenHelper {
	static final String DATABASE_NAME = "vtree.db";
	static final int DATABASE_VERSION = 1;

	public DatabaseHelper(Context context) {
		super(context, DATABASE_NAME, null, DATABASE_VERSION);
	}

	@Override
	public void onCreate(SQLiteDatabase db) {
		db.execSQL(MeraniaDao.CREATE_STATEMENT);
		db.execSQL(KmeneDao.CREATE_STATEMENT);		
	}

	/**
	 * riesi update struktury databazy
	 */
	@Override
	public void onUpgrade(SQLiteDatabase db, int current, int targetVersion) {
		if (current <= 5) {
			current = 6;
		}
		if (current == 6) {
			current = 7;
		}
		if (current == 7) {
			current = 8;
		}
	}

}
