package com.hk.vtree.dao;

import java.util.Date;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.provider.BaseColumns;

import com.hk.vtree.dao.stlpce.KmeneStlpce;
import com.hk.vtree.dao.stlpce.MeraniaStlpce;

/**
 * definuje tabulku a potrebne sql statementy
 * 
 */

public class MeraniaDao extends MeraniaStlpce implements
		android.provider.BaseColumns {

	public static final String CREATE_STATEMENT = "CREATE TABLE "
			+ MeraniaStlpce.TABLE + "(" + " " + BaseColumns._ID + " "
			+ MeraniaStlpce._ID_TYPE + "," + " " + MeraniaStlpce.NAZOV + " "
			+ MeraniaStlpce.NAZOV_TYPE + "," + " "
			+ MeraniaStlpce.CREATION_TIME + " "
			+ MeraniaStlpce.CREATION_TIME_TYPE + "," + " "
			+ MeraniaStlpce.ODBERATEL + " " + MeraniaStlpce.ODBERATEL_TYPE
			+ ");";

	int vymazJednoMeranie(DatabaseHelper dHelper, long meranieId) {
		SQLiteDatabase sqldb = dHelper.getWritableDatabase();
		int affected = 0;
		Cursor cursor = null;
		try {
			sqldb.beginTransaction();
			cursor = sqldb.query(KmeneStlpce.TABLE,
					new String[] { KmeneDao._ID }, KmeneStlpce.MERANIE_ID + "= ?",
					new String[] { String.valueOf(meranieId) }, null, null, null,
					null);
			if (cursor.moveToFirst()) {
				do {
					Long kmenId = cursor.getLong(0);
					affected += KmeneDao.vymazJedenKmen(dHelper, kmenId);
				} while (cursor.moveToNext());
			} 
			affected = sqldb.delete(MeraniaStlpce.TABLE,
					MeraniaDao._ID + "= ?",
					new String[] { String.valueOf(meranieId) });

			sqldb.setTransactionSuccessful();
		} finally {
			if (cursor != null) {
				cursor.close();
			}
			if (sqldb.inTransaction()) {
				sqldb.endTransaction();
			}
		}
		return affected;
	}

	public static int upravMeranieNazov(DatabaseHelper dHelper, long meranieId,
			String nazov) {
		int updates;
		String whereclause = MeraniaDao._ID + " = " + meranieId;
		ContentValues args = new ContentValues();
		args.put(MeraniaStlpce.NAZOV, nazov);
		SQLiteDatabase mDb = dHelper.getWritableDatabase();
		updates = mDb.update(MeraniaStlpce.TABLE, args, whereclause, null);

		return updates;
	}

	public static int upravMeranieOdberatel(DatabaseHelper dHelper,
			long meranieId, String odberatel) {
		int updates;
		String whereclause = MeraniaDao._ID + " = " + meranieId;
		ContentValues args = new ContentValues();
		args.put(MeraniaStlpce.ODBERATEL, odberatel);
		SQLiteDatabase mDb = dHelper.getWritableDatabase();
		updates = mDb.update(MeraniaStlpce.TABLE, args, whereclause, null);

		return updates;
	}

	public static long vlozMeranie(DatabaseHelper dHelper, String nazov,
			String odberatel) {
		long currentTime = new Date().getTime();
		ContentValues args = new ContentValues();
		args.put(MeraniaStlpce.NAZOV, nazov);
		args.put(MeraniaStlpce.ODBERATEL, odberatel);
		args.put(MeraniaStlpce.CREATION_TIME, currentTime);

		SQLiteDatabase sqldb = dHelper.getWritableDatabase();
		long meranieId = sqldb.insert(MeraniaStlpce.TABLE, null, args);

		return meranieId;
	}

	public static Cursor dajMeranie(DatabaseHelper dHelper, long meranieId,
			String[] stlpce) {
		SQLiteDatabase db = dHelper.getReadableDatabase();

		String[] selectionArgs = { String.valueOf(meranieId) };

		return db.query(MeraniaStlpce.TABLE, stlpce, MeraniaDao._ID + "= ?",
				selectionArgs, null, null, null);
	}

	public static Cursor dajMerania(DatabaseHelper dHelper) {
		SQLiteDatabase db = dHelper.getReadableDatabase();
		return db
				.query(MeraniaStlpce.TABLE, null, null, null, null, null, null);
	}

}
