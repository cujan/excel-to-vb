package com.hk.vtree.dao;

import java.util.Date;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.provider.BaseColumns;

import com.hk.vtree.dao.stlpce.KmeneStlpce;

/**
 * definuje tabulku a potrebne sql statementy
 * 
 */

public class KmeneDao extends KmeneStlpce implements
		android.provider.BaseColumns {

	public static final String CREATE_STATEMENT = "CREATE TABLE "
			+ KmeneStlpce.TABLE + "(" + " " + BaseColumns._ID + " "
			+ KmeneStlpce._ID_TYPE + "," + " " + KmeneStlpce.MERANIE_ID + " "
			+ KmeneStlpce.MERANIE_ID_TYPE + "," + " "
			+ KmeneStlpce.CREATION_TIME + " " + KmeneStlpce.CREATION_TIME_TYPE
			+ "," + " " + KmeneStlpce.DREVINA_TYP + " "
			+ KmeneStlpce.DREVINA_TYP_TYPE + "," + " "
			+ KmeneStlpce.DREVINA_DLZKA + " " + KmeneStlpce.DREVINA_DLZKA_TYPE
			+ "," + " " + KmeneStlpce.DREVINA_SIRKA + " "
			+ KmeneStlpce.DREVINA_SIRKA_TYPE + "," + " "
			+ KmeneStlpce.DREVINA_OBJEM + " " + KmeneStlpce.DREVINA_OBJEM_TYPE
			+ ");";

	public static int vymazJedenKmen(DatabaseHelper dHelper, long kmenId) {
		SQLiteDatabase sqldb = dHelper.getWritableDatabase();
		int affected = 0;
		Cursor cursor = null;
		try {
			sqldb.beginTransaction();

			affected = sqldb.delete(KmeneDao.TABLE, KmeneDao._ID + "= ?",
					new String[] { String.valueOf(kmenId) });

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

	public static int vymazKmeneMerania(DatabaseHelper dHelper, long meranieId) {
		SQLiteDatabase sqldb = dHelper.getWritableDatabase();
		int affected = 0;
		Cursor cursor = null;
		try {
			sqldb.beginTransaction();

			affected = sqldb.delete(KmeneStlpce.TABLE, KmeneDao.MERANIE_ID
					+ "= ?", new String[] { String.valueOf(meranieId) });

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

	public static long vlozKmen(DatabaseHelper dHelper, long meranieId,
			String typ, double dlzka, double sirka, double objem) {
		long currentTime = new Date().getTime();
		ContentValues args = new ContentValues();
		args.put(KmeneStlpce.MERANIE_ID, meranieId);
		args.put(KmeneStlpce.DREVINA_TYP, typ);
		args.put(KmeneStlpce.DREVINA_DLZKA, dlzka);
		args.put(KmeneStlpce.DREVINA_SIRKA, sirka);
		args.put(KmeneStlpce.DREVINA_OBJEM, objem);
		args.put(KmeneStlpce.CREATION_TIME, currentTime);

		SQLiteDatabase sqldb = dHelper.getWritableDatabase();
		long trackId = sqldb.insert(KmeneStlpce.TABLE, null, args);

		return trackId;
	}

	public static Cursor dajKmen(DatabaseHelper dHelper, long kmenId,
			String[] stlpce) {
		SQLiteDatabase db = dHelper.getReadableDatabase();

		String[] selectionArgs = { String.valueOf(kmenId) };

		return db.query(KmeneStlpce.TABLE, stlpce, KmeneDao._ID + "= ?",
				selectionArgs, null, null, null);
	}

	public static Cursor dajKmeneMerania(DatabaseHelper dHelper, long meranieId) {
		SQLiteDatabase db = dHelper.getReadableDatabase();
		String[] selectionArgs = { String.valueOf(meranieId) };
		return db.query(KmeneStlpce.TABLE, null, KmeneDao.MERANIE_ID + "= ?",
				selectionArgs, null, null, null);
	}

}
