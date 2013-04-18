package com.hk.queenb.dao;

import java.util.Arrays;
import java.util.List;

import android.content.ContentUris;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.net.Uri;
import android.provider.CalendarContract;

import com.hk.queenb.Constants;

public class SqliteDao {

	protected static final String DATABASE_NAME = "queenb";
	protected static final int DATABASE_VERSION = 2;

	protected static final String TB_NAME = "queenb_dates";

	// SpeciÃ¡lnÃ­ hodnota "_id", pro jednoduÅ¡Å¡Ã­ pouÅ¾itÃ­
	// SimpleCursorAdapteru
	public static final String COLUMN_ID = "_id";
	public static final String COLUMN_DATE = "entryDate";
	public static final String COLUMN_NOTE = "Note";
	public static final String COLUMN_EVENT_ID = "eventIDs";
	public static final String COLUMN_CALENDAR = "calendar";

	public static final String[] columns = { COLUMN_ID, COLUMN_DATE,
			COLUMN_NOTE, COLUMN_CALENDAR, COLUMN_EVENT_ID };

	protected static final String ORDER_BY = COLUMN_DATE + " DESC";

	private SQLiteOpenHelper openHelper;

	static class DatabaseHelper extends SQLiteOpenHelper {

		DatabaseHelper(Context context) {
			super(context, DATABASE_NAME, null, DATABASE_VERSION);
		}

		@Override
		public void onCreate(SQLiteDatabase db) {
			db.execSQL("CREATE TABLE " + TB_NAME + " (" + COLUMN_ID
					+ " INTEGER PRIMARY KEY," + COLUMN_DATE
					+ " DATE NOT NULL, " + COLUMN_NOTE + " TEXT, "
					+ COLUMN_CALENDAR + " TEXT, " + COLUMN_EVENT_ID + " TEXT);");
		}

		/*
		 * Ve skuteÄ�nosti je potÅ™eba, abychom uÅ¾ivatelÅ¯m nemazali data,
		 * vytvoÅ™it pro kaÅ¾dou zmÄ›nu struktury databÃ¡ze nÄ›jakÃ½
		 * upgradovacÃ­ nedestruktivnÃ­ SQL pÅ™Ã­kaz.
		 */
		@Override
		public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
			db.execSQL("DROP TABLE IF EXISTS " + TB_NAME);
			onCreate(db);
		}
	}

	public SqliteDao(Context ctx) {
		openHelper = new DatabaseHelper(ctx);
	}

	public Cursor getDates() {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		return db.query(TB_NAME, columns, null, null, null, null, ORDER_BY);
	}

	public Cursor getDates2() {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		String[] twoColumns = { COLUMN_ID, COLUMN_DATE, COLUMN_NOTE,
				COLUMN_EVENT_ID };

		return db.query(TB_NAME, twoColumns, null, null, null, null, ORDER_BY);
	}

	public Cursor getDate(long id) {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		String[] selectionArgs = { String.valueOf(id) };
		return db.query(TB_NAME, columns, COLUMN_ID + "= ?", selectionArgs,
				null, null, ORDER_BY);
	}

	public boolean dateExists(String date) {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		String[] twoColumns = { COLUMN_ID, COLUMN_DATE, COLUMN_NOTE };
		String[] selectionArgs = { date };
		Cursor cursor = db.query(TB_NAME, twoColumns, COLUMN_DATE + "= ?",
				selectionArgs, null, null, ORDER_BY);
		boolean exists = (cursor.getCount() > 0);
		cursor.close();
		db.close();
		return exists;
	}

	public boolean calendarExists(String date) {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		String[] selectionArgs = { date, Constants.YES };
		Cursor cursor = db.query(TB_NAME, columns, COLUMN_DATE + "= ? AND "
				+ COLUMN_CALENDAR + " = ? ", selectionArgs, null, null,
				ORDER_BY);
		boolean exists = (cursor.getCount() > 0);
		cursor.close();
		db.close();
		return exists;
	}

	public boolean deleteDate(long id, Context ctx) {
		SQLiteDatabase db = openHelper.getWritableDatabase();
		String[] selectionArgs = { String.valueOf(id), Constants.YES };
		int currentapiVersion = android.os.Build.VERSION.SDK_INT;
		if (currentapiVersion >= android.os.Build.VERSION_CODES.ICE_CREAM_SANDWICH) {

			Cursor cursor = db.query(TB_NAME, columns, COLUMN_ID + "= ? AND "
					+ COLUMN_CALENDAR + " = ? ", selectionArgs, null, null,
					ORDER_BY);
			boolean exists = (cursor.getCount() > 0);
			cursor.close();

			// vymazme zaznamy z kalendara
			if (exists) {
				cursor = getDate(id);
				int calendarIndex = cursor
						.getColumnIndex(SqliteDao.COLUMN_EVENT_ID);
				if (cursor.getCount() > 0) {
					cursor.moveToNext();
					String calendarText = cursor.getString(calendarIndex);
					if (calendarText != null && calendarText != "") {
						calendarText = calendarText.replace("[", "");
						calendarText = calendarText.replace("]", "");
						List<String> parsedIDs = Arrays.asList(calendarText
								.split(","));
						for (String eventID : parsedIDs) {
							Uri deleteUri = null;
							deleteUri = ContentUris.withAppendedId(
									CalendarContract.Events.CONTENT_URI,
									Long.valueOf(eventID.trim()));
							int rows = ctx.getContentResolver().delete(
									deleteUri, null, null);

						}
					}
				}

			}
		}

		String[] selectionArgs2 = { String.valueOf(id) };

		int deletedCount = db
				.delete(TB_NAME, COLUMN_ID + "= ?", selectionArgs2);
		db.close();
		return deletedCount > 0;
	}

	public long insertDate(String date, String note, String calendar) {
		SQLiteDatabase db = openHelper.getWritableDatabase();

		ContentValues values = new ContentValues();
		values.put(COLUMN_DATE, date);
		values.put(COLUMN_NOTE, note);
		values.put(COLUMN_CALENDAR, calendar);

		long id = db.insert(TB_NAME, null, values);
		db.close();
		return id;
	}

	public long updateCalendar(String date, String calendar, String eventIDs) {
		SQLiteDatabase db = openHelper.getWritableDatabase();
		ContentValues values = new ContentValues();
		values.put(COLUMN_CALENDAR, calendar);
		values.put(COLUMN_EVENT_ID, eventIDs);
		String[] selectionArgs = { date };
		long id = db.update(TB_NAME, values, COLUMN_DATE + "=?", selectionArgs);
		db.close();
		return id;
	}

	public void close() {
		openHelper.close();
	}

	public boolean existsRecord() {
		SQLiteDatabase db = openHelper.getReadableDatabase();

		String[] selectionArgs = { TB_NAME };
		String[] column = { "name" };
		Cursor cursor = db.query("sqlite_master", column,
				"type ='table' AND name = ?", selectionArgs, null, null, null);
		boolean exists = (cursor.getCount() > 0);
		cursor.close();
		db.close();
		return exists;
	}

	public Cursor getNote(String sqlDate) {
		SQLiteDatabase db = openHelper.getReadableDatabase();
		String[] twoColumns = { COLUMN_ID, COLUMN_NOTE };
		String[] selectionArgs = { sqlDate };
		return db.query(TB_NAME, twoColumns, COLUMN_DATE + "= ?",
				selectionArgs, null, null, ORDER_BY);

	}
}
