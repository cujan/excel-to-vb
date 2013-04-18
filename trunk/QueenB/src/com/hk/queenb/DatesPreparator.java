package com.hk.queenb;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import java.util.List;
import java.util.TimeZone;

import android.annotation.SuppressLint;
import android.app.AlertDialog;
import android.app.ProgressDialog;
import android.content.ContentResolver;
import android.content.ContentValues;
import android.content.DialogInterface;
import android.content.res.Resources;
import android.database.Cursor;
import android.net.Uri;
import android.os.AsyncTask;
import android.provider.CalendarContract;
import android.support.v4.app.FragmentActivity;
import android.text.InputFilter;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.hk.queenb.dao.SqliteDao;

public class DatesPreparator {
	private Calendar preveseniePlastu = Calendar.getInstance();
	private Calendar vlozenieSuse = Calendar.getInstance();
	private Calendar pripravaSadky = Calendar.getInstance();
	private Calendar prelozenieSerie = Calendar.getInstance();
	private Calendar premiestnenieMatecniku1 = Calendar.getInstance();
	private Calendar kontrolaZavieckovania = Calendar.getInstance();
	private Calendar premiestnenieMatecniku2 = Calendar.getInstance();
	private Calendar skolkovanie = Calendar.getInstance();
	private Calendar premiestnenieMatecniku3 = Calendar.getInstance();
	private Calendar liahnutie = Calendar.getInstance();
	private Calendar zuzitkovanieMatiek = Calendar.getInstance();
	private Calendar vaznenieOd = Calendar.getInstance();
	private Calendar vaznenieDo = Calendar.getInstance();
	private Calendar preletOd = Calendar.getInstance();
	private Calendar preletDo = Calendar.getInstance();
	private Calendar snubnePrelety = Calendar.getInstance();
	private Calendar prenikanieSpermii = Calendar.getInstance();
	private Calendar prveNakladeneVajicka = Calendar.getInstance();
	private Calendar initialDate;
	private String sqlDate;
	private List<String> labels = new ArrayList<String>();
	private FragmentActivity context;

	@SuppressWarnings("deprecation")
	public DatesPreparator(final Calendar newDate, FragmentActivity c) {
		super();
		initialDate = (Calendar) newDate.clone();
		preveseniePlastu = (Calendar) newDate.clone();
		vlozenieSuse = (Calendar) newDate.clone();
		pripravaSadky = (Calendar) newDate.clone();
		prelozenieSerie = (Calendar) newDate.clone();
		premiestnenieMatecniku1 = (Calendar) newDate.clone();
		kontrolaZavieckovania = (Calendar) newDate.clone();
		premiestnenieMatecniku2 = (Calendar) newDate.clone();
		skolkovanie = (Calendar) newDate.clone();
		premiestnenieMatecniku3 = (Calendar) newDate.clone();
		liahnutie = (Calendar) newDate.clone();
		zuzitkovanieMatiek = (Calendar) newDate.clone();
		vaznenieOd = (Calendar) newDate.clone();
		vaznenieDo = (Calendar) newDate.clone();
		preletOd = (Calendar) newDate.clone();
		preletDo = (Calendar) newDate.clone();
		snubnePrelety = (Calendar) newDate.clone();
		prenikanieSpermii = (Calendar) newDate.clone();
		prveNakladeneVajicka = (Calendar) newDate.clone();
		sqlDate = Constants.sqlFormat.format(newDate.getTime());

		context = c;
		calcDays();
		prepareLabels();
	}

	private void calcDays() {

		preveseniePlastu.add(Calendar.DATE, -9);
		vlozenieSuse.add(Calendar.DATE, -4);
		prelozenieSerie.add(Calendar.DATE, 1);
		premiestnenieMatecniku1.add(Calendar.DATE, 2);
		kontrolaZavieckovania.add(Calendar.DATE, 5);
		premiestnenieMatecniku2.add(Calendar.DATE, 5);
		skolkovanie.add(Calendar.DATE, 10);
		premiestnenieMatecniku3.add(Calendar.DATE, 11);
		liahnutie.add(Calendar.DATE, 12);
		zuzitkovanieMatiek.add(Calendar.DATE, 13);
		vaznenieOd.add(Calendar.DATE, 13);
		vaznenieDo.add(Calendar.DATE, 15);
		preletOd.add(Calendar.DATE, 15);
		preletDo.add(Calendar.DATE, 17);
		snubnePrelety.add(Calendar.DATE, 19);
		prenikanieSpermii.add(Calendar.DATE, 21);
		prveNakladeneVajicka.add(Calendar.DATE, 23);
	}

	public void updateViews() {
		TextView preveseniePlastuT = (TextView) context
				.findViewById(R.id.preveseniePlastu);
		preveseniePlastuT.setText(Constants.formatDate.format(preveseniePlastu
				.getTime()));
		TextView vlozenieSuseT = (TextView) context
				.findViewById(R.id.vlozenieSuse);
		vlozenieSuseT.setText(Constants.formatDate.format(vlozenieSuse
				.getTime()));
		TextView pripravaSadkyT = (TextView) context
				.findViewById(R.id.pripravaSadky);
		pripravaSadkyT.setText(Constants.formatDate.format(pripravaSadky
				.getTime()));
		TextView prelozenieSerieT = (TextView) context
				.findViewById(R.id.prelozenieSerie);
		prelozenieSerieT.setText(Constants.formatDate.format(prelozenieSerie
				.getTime()));
		TextView premiestnenieMatecniku1T = (TextView) context
				.findViewById(R.id.premiestnenieMatecniku1);
		premiestnenieMatecniku1T.setText(Constants.formatDate
				.format(premiestnenieMatecniku1.getTime()));
		TextView kontrolaZavieckovaniaT = (TextView) context
				.findViewById(R.id.kontrolaZavieckovania);
		kontrolaZavieckovaniaT.setText(Constants.formatDate
				.format(kontrolaZavieckovania.getTime()));
		TextView premiestnenieMatecniku2T = (TextView) context
				.findViewById(R.id.premiestnenieMatecniku2);
		premiestnenieMatecniku2T.setText(Constants.formatDate
				.format(premiestnenieMatecniku2.getTime()));
		TextView skolkovanieT = (TextView) context
				.findViewById(R.id.skolkovanie);
		skolkovanieT
				.setText(Constants.formatDate.format(skolkovanie.getTime()));
		TextView premiestnenieMatecniku3T = (TextView) context
				.findViewById(R.id.premiestnenieMatecniku3);
		premiestnenieMatecniku3T.setText(Constants.formatDate
				.format(premiestnenieMatecniku3.getTime()));
		TextView liahnutieT = (TextView) context.findViewById(R.id.liahnutie);
		liahnutieT.setText(Constants.formatDate.format(liahnutie.getTime()));
		TextView zuzitkovanieMatiekT = (TextView) context
				.findViewById(R.id.zuzitkovanieMatiek);
		zuzitkovanieMatiekT.setText(Constants.formatDate
				.format(zuzitkovanieMatiek.getTime()));
		TextView vaznenieOdT = (TextView) context.findViewById(R.id.vaznenieOd);
		vaznenieOdT.setText(Constants.formatDate.format(vaznenieOd.getTime()));
		TextView vaznenieDoT = (TextView) context.findViewById(R.id.vaznenieDo);
		vaznenieDoT.setText(Constants.formatDate.format(vaznenieDo.getTime()));
		TextView preletOdT = (TextView) context.findViewById(R.id.preletOd);
		preletOdT.setText(Constants.formatDate.format(preletOd.getTime()));
		TextView preletDoT = (TextView) context.findViewById(R.id.preletDo);
		preletDoT.setText(Constants.formatDate.format(preletDo.getTime()));
		TextView snubnePreletyT = (TextView) context
				.findViewById(R.id.snubnePrelety);
		snubnePreletyT.setText(Constants.formatDate.format(snubnePrelety
				.getTime()));
		TextView prenikanieSpermiiT = (TextView) context
				.findViewById(R.id.prenikanieSpermii);
		prenikanieSpermiiT.setText(Constants.formatDate
				.format(prenikanieSpermii.getTime()));
		TextView prveNakladeneVajickaT = (TextView) context
				.findViewById(R.id.prveNakladeneVajicka);
		prveNakladeneVajickaT.setText(Constants.formatDate
				.format(prveNakladeneVajicka.getTime()));
	}

	public String getSqlDate() {
		return sqlDate;
	}

	public boolean allowedDate(Calendar newDate) {
		Calendar now = Calendar.getInstance();
		now.add(Calendar.DATE, -23);
		if (newDate.before(now))
			return false;
		return true;
	}

	public void sendToCalendar() {
		new AddToCal().execute("");
	}

	private void prepareLabels() {
		String[] labels = { "preveseniePlastu", "vlozenieSuse",
				"pripravaSadky", "prelozenieSerie", "premiestnenieMatecniku1",
				"kontrolaZavieckovania", "premiestnenieMatecniku2",
				"skolkovanie", "premiestnenieMatecniku3", "liahnutie",
				"zuzitkovanieMatiek", "vaznenieOd", "vaznenieDo", "preletOd",
				"preletDo", "snubnePrelety", "prenikanieSpermii",
				"prveNakladeneVajicka" };
		Collections.addAll(this.labels, labels);

	}

	private Calendar getDateFromLabel(String label) {
		if (label == "preveseniePlastu") {
			return preveseniePlastu;
		} else if (label == "vlozenieSuse") {
			return vlozenieSuse;
		} else if (label == "pripravaSadky") {
			return pripravaSadky;
		} else if (label == "prelozenieSerie") {
			return prelozenieSerie;
		} else if (label == "premiestnenieMatecniku1") {
			return premiestnenieMatecniku1;
		} else if (label == "kontrolaZavieckovania") {
			return kontrolaZavieckovania;
		} else if (label == "premiestnenieMatecniku2") {
			return premiestnenieMatecniku2;
		} else if (label == "skolkovanie") {
			return skolkovanie;
		} else if (label == "premiestnenieMatecniku3") {
			return premiestnenieMatecniku3;
		} else if (label == "liahnutie") {
			return liahnutie;
		} else if (label == "zuzitkovanieMatiek") {
			return zuzitkovanieMatiek;
		} else if (label == "vaznenieOd") {
			return vaznenieOd;
		} else if (label == "vaznenieDo") {
			return vaznenieDo;
		} else if (label == "preletOd") {
			return preletOd;
		} else if (label == "preletDo") {
			return preletDo;
		} else if (label == "snubnePrelety") {
			return snubnePrelety;
		} else if (label == "prenikanieSpermii") {
			return prenikanieSpermii;
		} else if (label == "prveNakladeneVajicka") {
			return prveNakladeneVajicka;
		} else
			return Calendar.getInstance();
	}

	private int getTextViewID(String label) {
		if (label == "preveseniePlastu") {
			return R.id.preveseniePlastu;
		} else if (label == "vlozenieSuse") {
			return R.id.vlozenieSuse;
		} else if (label == "pripravaSadky") {
			return R.id.pripravaSadky;
		} else if (label == "prelozenieSerie") {
			return R.id.prelozenieSerie;
		} else if (label == "premiestnenieMatecniku1") {
			return R.id.premiestnenieMatecniku1;
		} else if (label == "kontrolaZavieckovania") {
			return R.id.kontrolaZavieckovania;
		} else if (label == "premiestnenieMatecniku2") {
			return R.id.premiestnenieMatecniku2;
		} else if (label == "skolkovanie") {
			return R.id.skolkovanie;
		} else if (label == "premiestnenieMatecniku3") {
			return R.id.premiestnenieMatecniku3;
		} else if (label == "liahnutie") {
			return R.id.liahnutie;
		} else if (label == "zuzitkovanieMatiek") {
			return R.id.zuzitkovanieMatiek;
		} else if (label == "vaznenieOd") {
			return R.id.vaznenieOd;
		} else if (label == "vaznenieDo") {
			return R.id.vaznenieDo;
		} else if (label == "preletOd") {
			return R.id.preletOd;
		} else if (label == "preletDo") {
			return R.id.preletDo;
		} else if (label == "snubnePrelety") {
			return R.id.snubnePrelety;
		} else if (label == "prenikanieSpermii") {
			return R.id.prenikanieSpermii;
		} else if (label == "prveNakladeneVajicka") {
			return R.id.prveNakladeneVajicka;
		} else
			return -1;
	}

	public FragmentActivity getContext() {
		return context;
	}

	private class AddToCal extends AsyncTask<String, Void, String> {
		private ArrayList<String> eventIds = new ArrayList<String>();
		private Long calendarID = Long.valueOf(-1);
		private int status = -1;
		private String poznamka;

		// Progress Dialog
		private ProgressDialog pDialog;

		@Override
		protected String doInBackground(String... params) {
			Resources res = context.getResources();
			if (calendarID < 0)
				return "UNSUCCESSFUL";

			for (String s : labels) {
				TextView textView = (TextView) context
						.findViewById(getTextViewID(s));
				Calendar beginTime = (Calendar) getDateFromLabel(s).clone();
				beginTime.set(Calendar.HOUR, Constants.HOUR_NOTIFY_START);
				Calendar endTime = (Calendar) getDateFromLabel(s).clone();
				endTime.set(Calendar.HOUR, Constants.HOUR_NOTIFY_END);

				// Insert Event
				ContentResolver cr = context.getContentResolver();
				ContentValues values = new ContentValues();
				values.put(CalendarContract.Events.DTSTART,
						beginTime.getTimeInMillis());
				values.put(CalendarContract.Events.DTEND,
						endTime.getTimeInMillis());
				values.put(CalendarContract.Events.EVENT_TIMEZONE, TimeZone
						.getDefault().toString());
				values.put(
						CalendarContract.Events.TITLE,
						res.getString(R.string.chov_matiek_nadpis)
								+ "-"
								+ poznamka
								+ "-"
								+ Constants.formatDate.format(
										initialDate.getTime()).toString());
				values.put(CalendarContract.Events.DESCRIPTION, textView
						.getHint().toString());
				values.put(CalendarContract.Events.CALENDAR_ID, calendarID);
				Uri uri2 = cr.insert(CalendarContract.Events.CONTENT_URI,
						values);

				// Retrieve ID for new event
				String eventIDString = uri2.getLastPathSegment();
				Long eventID = Long.parseLong(eventIDString);

				String reminderUriString = "content://com.android.calendar/reminders";

				ContentValues reminderValues = new ContentValues();

				reminderValues.put("event_id", eventID);
				reminderValues.put("minutes",
						Constants.CALENDAR_REMINDER_MINUTES); // Default value
																// of the
				// system. Minutes is a
				// integer

				reminderValues.put("method", 1); // Alert Methods: Default(0),
													// Alert(1), Email(2),
													// SMS(3)

				Uri reminderUri = cr.insert(Uri.parse(reminderUriString),
						reminderValues);

				eventIds.add(eventID.toString());

				// Intent intent = new Intent(Intent.ACTION_INSERT)
				// .setData(Events.CONTENT_URI)
				// .putExtra(CalendarContract.EXTRA_EVENT_BEGIN_TIME,
				// beginTime.getTimeInMillis())
				// .putExtra(CalendarContract.EXTRA_EVENT_END_TIME,
				// endTime.getTimeInMillis())
				// .putExtra(Events.EVENT_TIMEZONE, TimeZone.getDefault())
				// .putExtra(
				// Events.TITLE,
				// res.getString(R.string.chov_matiek_nadpis)
				// + " "
				// + Constants.formatDate.format(
				// initialDate.getTime())
				// .toString())
				// .putExtra(Events.DESCRIPTION, textView.getHint());
				// context.startActivity(intent);
			}
			status = 1;
			return "Executed";
		}

		@Override
		protected void onPostExecute(String result) {
			if (status < 0) {
				if (pDialog != null && pDialog.isShowing())
					pDialog.dismiss();
				return;
			}
			SqliteDao dbConnect = new SqliteDao(context);
			String IDs = eventIds.toString();
			IDs = IDs.replace("[", "");
			IDs = IDs.replace("]", "");
			dbConnect.updateCalendar(getSqlDate(), Constants.YES, IDs);
			Button doKalendara = (Button) context
					.findViewById(R.id.do_kalendara);
			doKalendara.setVisibility(View.GONE);

			Button doDb = (Button) context.findViewById(R.id.ulozit_event);
			doDb.setVisibility(View.GONE);
			pDialog.dismiss();
		}

		@SuppressLint("InlinedApi")
		@SuppressWarnings("deprecation")
		@Override
		protected void onPreExecute() {
			super.onPreExecute();
			Uri uri = CalendarContract.Calendars.CONTENT_URI;
			String[] projection = new String[] {
					CalendarContract.Calendars._ID,
					CalendarContract.Calendars.ACCOUNT_NAME,
					CalendarContract.Calendars.CALENDAR_DISPLAY_NAME,
					CalendarContract.Calendars.NAME,
					CalendarContract.Calendars.CALENDAR_COLOR };

			Cursor calendarCursor = context.managedQuery(uri, projection, null,
					null, null);
			int idIndex = calendarCursor
					.getColumnIndex(CalendarContract.Calendars._ID);

			if (calendarCursor.getCount() < 1) {
				Toast.makeText(context, R.string.no_calendar_configured,
						Toast.LENGTH_SHORT).show();
				return;
			} else {
				calendarCursor.moveToNext();
				calendarID = Long.valueOf(calendarCursor.getString(idIndex));
			}

			calendarCursor.close();

			SqliteDao SqliteDao = new SqliteDao(context);
			Cursor date = SqliteDao.getNote(getSqlDate());
			int noteIndex = date.getColumnIndex(SqliteDao.COLUMN_NOTE);
			date.moveToNext();
			poznamka = date.getString(noteIndex);

			date.close();
			SqliteDao.close();

			Resources res = context.getResources();
			pDialog = new ProgressDialog(context);
			pDialog.setMessage(res.getString(R.string.writing_to_calendar));
			pDialog.setIndeterminate(false);
			pDialog.setCancelable(false);
			pDialog.show();

		}

		@Override
		protected void onProgressUpdate(Void... values) {
		}
	}

}
