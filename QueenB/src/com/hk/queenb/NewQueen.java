package com.hk.queenb;

import java.text.ParseException;
import java.util.Calendar;
import java.util.GregorianCalendar;

import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.graphics.Typeface;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.text.InputFilter;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.hk.queenb.dao.SqliteDao;

public class NewQueen extends FragmentActivity {

	/** Private members of the class */
	private TextView pDisplayDate;
	private int pYear;
	private int pMonth;
	private int pDay;
	private DatesPreparator newDates;
	private String inCalendar = Constants.NO;

	/**
	 * This integer will uniquely define the dialog to be used for displaying
	 * date picker.
	 */
	static final int DATE_DIALOG_ID = 0;

	/** Callback received when the user "picks" a date in the dialog */
	private DatePickerDialog.OnDateSetListener pDateSetListener = new DatePickerDialog.OnDateSetListener() {

		public void onDateSet(DatePicker view, int year, int monthOfYear,
				int dayOfMonth) {
			pYear = year;
			pMonth = monthOfYear;
			pDay = dayOfMonth;
			Calendar newDate = GregorianCalendar.getInstance();
			newDate.set(pYear, pMonth, pDay); // January 30th 2000
			updateDisplay(newDate, Constants.EVENT_NEW);
		}
	};

	/** Updates the date in the TextView */
	
	private void updateDisplay(Calendar newDate, String event) {
		newDates = new DatesPreparator(newDate, this);
		if (!newDates.allowedDate(newDate) && event == Constants.EVENT_NEW) {
			Toast.makeText(this, R.string.date_old, Toast.LENGTH_LONG).show();
			return;
		}
		newDates.updateViews();
		pDisplayDate.setText(Constants.formatDate.format(newDate.getTime()));
		if (event == Constants.EVENT_NEW) {
			int currentapiVersion = android.os.Build.VERSION.SDK_INT;
			if (currentapiVersion >= android.os.Build.VERSION_CODES.ICE_CREAM_SANDWICH) {
				Button doKalendara = (Button) this
						.findViewById(R.id.do_kalendara);
				doKalendara.setVisibility(View.VISIBLE);
			}
			Button doDb = (Button) this.findViewById(R.id.ulozit_event);
			doDb.setVisibility(View.VISIBLE);
		}

	}

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.new_queen);
		Button ulozitEvent= (Button) this.findViewById(R.id.ulozit_event);
		Button doKalendara = (Button) this.findViewById(R.id.do_kalendara);
		
		Typeface font = Typeface
				.createFromAsset(getAssets(), "kristen-itc.ttf");
		ulozitEvent.setTypeface(font);
		doKalendara.setTypeface(font);
		String dbDate = getIntent().getStringExtra(Constants.DATE);
		String dbNote = getIntent().getStringExtra(Constants.NOTE);
		pDisplayDate = (TextView) findViewById(R.id.displayDate);
		TextView textDate = (TextView) findViewById(R.id.textDate);
		if (dbDate != null && dbDate != "") {
			pDisplayDate.setVisibility(View.GONE);
			textDate.setVisibility(View.GONE);
			Calendar cal = Calendar.getInstance();
			try {
				cal.setTime(Constants.sqlFormat.parse(dbDate));
				updateDisplay(cal, Constants.EVENT_DETAIL);
				if (dbNote != null && dbNote != "") {
					TextView note = (TextView) findViewById(R.id.note);
					note.setText(dbNote);
					note.setVisibility(View.VISIBLE);
				}
				SqliteDao dbConnect = new SqliteDao(this);
				if (!dbConnect.calendarExists(newDates.getSqlDate())) {
					int currentapiVersion = android.os.Build.VERSION.SDK_INT;
					if (currentapiVersion >= android.os.Build.VERSION_CODES.ICE_CREAM_SANDWICH) {
						Button doKalendara1 = (Button) this
								.findViewById(R.id.do_kalendara);						
						doKalendara1.setVisibility(View.VISIBLE);
						doKalendara1.setTypeface(font);
					}
				}
			} catch (ParseException e) {

			}

		} else {

			/** Capture our View elements */

			/** Get the current date */
			final Calendar cal = Calendar.getInstance();
			pYear = cal.get(Calendar.YEAR);
			pMonth = cal.get(Calendar.MONTH);
			pDay = cal.get(Calendar.DAY_OF_MONTH);

			/** Display the current date in the TextView */
			// updateDisplay();
		}
	}

	@SuppressWarnings("deprecation")
	public void onZadajDatum(View v) {
		showDialog(DATE_DIALOG_ID);
	}

	/** Create a new dialog for date picker */
	@Override
	protected Dialog onCreateDialog(int id) {
		switch (id) {
		case DATE_DIALOG_ID:
			return new DatePickerDialog(this, pDateSetListener, pYear, pMonth,
					pDay);
		}
		return null;
	}

	public void onPridatDoKalendara(View v) {

		SqliteDao dbConnect = new SqliteDao(this);
		if (dbConnect.calendarExists(newDates.getSqlDate())) {
			Toast.makeText(this, R.string.date_exists, Toast.LENGTH_LONG)
					.show();
		} else {
			if (dbConnect.dateExists(newDates.getSqlDate())) {
				Toast.makeText(this, R.string.date_exists, Toast.LENGTH_LONG)
						.show();
			} else {
				AlertDialog.Builder alert = new AlertDialog.Builder(this);

				alert.setTitle(R.string.note_dialog);
				alert.setMessage(R.string.note_dialog_text);

				// Set an EditText view to get user input
				final EditText input = new EditText(this);
				InputFilter[] FilterArray = new InputFilter[1];
				FilterArray[0] = new InputFilter.LengthFilter(
						Constants.DIALOG_LENGTH);
				input.setFilters(FilterArray);

				alert.setView(input);

				alert.setPositiveButton("Ok",
						new DialogInterface.OnClickListener() {
							public void onClick(DialogInterface dialog,
									int whichButton) {
								String value = input.getText().toString();
								SqliteDao dbConnect = new SqliteDao(newDates
										.getContext());
								long id = dbConnect.insertDate(
										newDates.getSqlDate(), value,
										inCalendar);

								if (id > -1) {
									Toast.makeText(newDates.getContext(),
											R.string.date_added,
											Toast.LENGTH_LONG).show();
									Button doDb = (Button) newDates
											.getContext().findViewById(
													R.id.ulozit_event);
									doDb.setVisibility(View.GONE);
									newDates.sendToCalendar();
								} else {
									Toast.makeText(
											newDates.getContext(),
											R.string.date_not_added_and_calendar_cancelled,
											Toast.LENGTH_LONG).show();
								}

							}
						});

				alert.show();

			}

		}
		dbConnect.close();
	}

	public void onUlozitDoDb(View v) {
		SqliteDao dbConnect = new SqliteDao(this);
		if (dbConnect.dateExists(newDates.getSqlDate())) {
			Toast.makeText(this, R.string.date_exists, Toast.LENGTH_LONG)
					.show();
		} else {
			AlertDialog.Builder alert = new AlertDialog.Builder(this);

			alert.setTitle(R.string.note_dialog);
			alert.setMessage(R.string.note_dialog_text);

			// Set an EditText view to get user input
			final EditText input = new EditText(this);
			InputFilter[] FilterArray = new InputFilter[1];
			FilterArray[0] = new InputFilter.LengthFilter(
					Constants.DIALOG_LENGTH);
			input.setFilters(FilterArray);

			alert.setView(input);

			alert.setPositiveButton("Ok",
					new DialogInterface.OnClickListener() {
						public void onClick(DialogInterface dialog,
								int whichButton) {
							String value = input.getText().toString();
							SqliteDao dbConnect = new SqliteDao(newDates
									.getContext());
							long id = dbConnect.insertDate(
									newDates.getSqlDate(), value, inCalendar);

							if (id > -1) {
								Toast.makeText(newDates.getContext(),
										R.string.date_added, Toast.LENGTH_LONG)
										.show();
								Button doDb = (Button) newDates.getContext()
										.findViewById(R.id.ulozit_event);
								doDb.setVisibility(View.GONE);
							} else {
								Toast.makeText(newDates.getContext(),
										R.string.date_not_added,
										Toast.LENGTH_LONG).show();
							}

						}
					});

			alert.setNegativeButton(R.string.cancel,
					new DialogInterface.OnClickListener() {
						public void onClick(DialogInterface dialog,
								int whichButton) {
							// Canceled.
						}
					});

			alert.show();

		}
		dbConnect.close();
	}

}
