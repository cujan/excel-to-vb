package com.hk.queenb;

import java.text.SimpleDateFormat;

public class Constants {
	public static final SimpleDateFormat formatDate = new SimpleDateFormat(
			"E, dd.MMM.yyyy");

	public static final SimpleDateFormat sqlFormat = new SimpleDateFormat(
			"yyyy-MM-dd");

	public static final String DATE = "date";
	public static final String NOTE = "note";
	public static final String EVENT_NEW = "new";
	public static final String EVENT_DETAIL = "detail";
	public static final String NO = "n";
	public static final String YES = "y";
	public static final int DIALOG_LENGTH = 30;
	public static final int HOUR_NOTIFY_START = 8;
	public static final int HOUR_NOTIFY_END = 10;

	public static final int CALENDAR_REMINDER_MINUTES = 10;

}
