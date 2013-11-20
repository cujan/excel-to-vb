package com.hk.vtree.views;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.text.Editable;
import android.text.InputFilter;
import android.text.TextWatcher;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.hk.vtree.R;
import com.hk.vtree.dao.DatabaseHelper;
import com.hk.vtree.dao.KmeneDao;
import com.hk.vtree.dao.MeraniaDao;
import com.hk.vtree.dao.stlpce.MeraniaStlpce;
import com.hk.vtree.utils.Constants;

public class ObjemBezKoryNovy extends Activity {

	private DatabaseHelper mDbHelper;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);

		ziskajDetajlyNovehoMerania();
		setContentView(R.layout.objem_bez_kory);

		EditText sirkaKmena = (EditText) findViewById(R.id.editTextSirkaKmena);
		sirkaKmena.addTextChangedListener(new TextWatcher() {

			public void afterTextChanged(Editable s) {
			}

			public void beforeTextChanged(CharSequence s, int start, int count,
					int after) {
			}

			public void onTextChanged(CharSequence s, int start, int before,
					int count) {
				vypocitajObjemKmena();
			}
		});

		EditText dlzkaKmena = (EditText) findViewById(R.id.editTextDlzkaKmena);
		dlzkaKmena.addTextChangedListener(new TextWatcher() {

			public void afterTextChanged(Editable s) {
			}

			public void beforeTextChanged(CharSequence s, int start, int count,
					int after) {
			}

			public void onTextChanged(CharSequence s, int start, int before,
					int count) {
				vypocitajObjemKmena();
			}
		});

	}

	private void ziskajDetajlyNovehoMerania() {
		AlertDialog.Builder alert = new AlertDialog.Builder(this);

		alert.setTitle(R.string.nove_meranie_dialog);
		alert.setMessage(R.string.nove_meranie_dialog_text);

		InputFilter[] FilterArray = new InputFilter[1];
		FilterArray[0] = new InputFilter.LengthFilter(Constants.DIALOG_LENGTH);

		LinearLayout layout = new LinearLayout(this);
		layout.setOrientation(LinearLayout.VERTICAL);
		// Set an EditText view to get user input
		final EditText nazov = new EditText(this);
		nazov.setHint(MeraniaStlpce.NAZOV);
		nazov.setFilters(FilterArray);
		layout.addView(nazov);
		final EditText odberatel = new EditText(this);
		odberatel.setHint(MeraniaStlpce.ODBERATEL);
		odberatel.setFilters(FilterArray);
		layout.addView(odberatel);
		final EditText cisloDokladu = new EditText(this);
		cisloDokladu.setHint(MeraniaStlpce.CISLO_DOKLADU);
		cisloDokladu.setFilters(FilterArray);
		layout.addView(cisloDokladu);

		alert.setView(layout);

		alert.setPositiveButton("Ok", new DialogInterface.OnClickListener() {
			public void onClick(DialogInterface dialog, int whichButton) {
				String meranieNazovText = nazov.getText().toString();
				String meranieOdberatelText = odberatel.getText().toString();
				String meranieCisloDokladuText = cisloDokladu.getText().toString();
				TextView nazov = (TextView) ObjemBezKoryNovy.this
						.findViewById(R.id.meranieNazov);
				nazov.setText(meranieNazovText);
				TextView odberatel = (TextView) ObjemBezKoryNovy.this
						.findViewById(R.id.meranieOdberatel);
				odberatel.setText(meranieOdberatelText);
				TextView cisloDokladu = (TextView) ObjemBezKoryNovy.this
						.findViewById(R.id.meranieCisloDokladu);
				cisloDokladu.setText(meranieCisloDokladuText);
			}
		});

		alert.setNegativeButton(R.string.cancel,
				new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int whichButton) {
						Toast.makeText(ObjemBezKoryNovy.this,
								R.string.will_not_be_saved, Toast.LENGTH_LONG)
								.show();

					}
				});

		alert.show();

	}

	public void vypocitajObjemKmena() {
		
		TextView vysledok = (TextView) findViewById(R.id.textViewVysledok);
		vysledok.setText(getResultText());
		
		
	}

	public String getResultText() {
		return getResult() + " m3";
	}

	public double getResult() {
		EditText dlzkaKmena = (EditText) findViewById(R.id.editTextDlzkaKmena);
		EditText sirkaKmena = (EditText) findViewById(R.id.editTextSirkaKmena);
		// nerob nic ked nie je zadane vsetko potrebne
		if (dlzkaKmena.getText().toString().isEmpty()
				|| sirkaKmena.getText().toString().isEmpty())
			return 0;
		Double dlzka = Double.valueOf(dlzkaKmena.getText().toString());
		Double sirka = Double.valueOf(sirkaKmena.getText().toString());

		Double objem;
		Double hrubkaKory = koeficient();

		objem = (Math.PI * dlzka * Math.pow((sirka - hrubkaKory), 2)) / 40000;
		// DecimalFormat f = new DecimalFormat("##.00");
		// f.format(objem);
		double zaokruhlene = Math.round(objem * 100) / 100D;

		return zaokruhlene;
	}

	public double koeficient() {
		EditText sirkaKmena = (EditText) findViewById(R.id.editTextSirkaKmena);
		// vyber typu stromu a porovnanie a nasledne pouzitie prislusnej
		// konstanty

		Spinner typDrevaSpinner = (Spinner) findViewById(R.id.spinnerTypDreva);

		String typStromu = "";

		String vybranyTypStromu = String.valueOf(typDrevaSpinner
				.getSelectedItem());

		if (vybranyTypStromu == null
				|| vybranyTypStromu.equals(String.valueOf(""))
				|| vybranyTypStromu.isEmpty()) {
			Toast.makeText(this, R.string.no_tree_type_selected,
					Toast.LENGTH_SHORT).show();
			// return;
		} else {
			typStromu = Constants.KeyMap.get(vybranyTypStromu);
		}

		Double sirka = Double.valueOf(sirkaKmena.getText().toString());
		double hrubka = 0;
		double p0 = 0;
		double p1 = 0;
		double p2 = 0;

		if (typStromu == "sm") {
			p0 = Constants.P0SM;
			p1 = Constants.P1SM;
			p2 = Constants.P2SM;
		} else if (typStromu == "db") {
			p0 = Constants.P0DB;
			p1 = Constants.P1DB;
			p2 = Constants.P2DB;
		} else if (typStromu == "bk") {
			p0 = Constants.P0BK;
			p1 = Constants.P1BK;
			p2 = Constants.P2BK;
		} else if (typStromu == "bo") {
			p0 = Constants.P0BO;
			p1 = Constants.P1BO;
			p2 = Constants.P2BO;
		}

		hrubka = p0 + p1 * Math.pow(sirka, p2);

		return hrubka;
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.objem_bez_kory, menu);
		return true;
	}

	public void onClickUlozHodnotu(View v) {
		initializeDbHelper(this);
		TextView meranieIdText = (TextView) this.findViewById(R.id.meranie_id);
		EditText dlzkaKmena = (EditText) findViewById(R.id.editTextDlzkaKmena);
		EditText sirkaKmena = (EditText) findViewById(R.id.editTextSirkaKmena);
		

		Spinner typDrevaSpinner = (Spinner) findViewById(R.id.spinnerTypDreva);
		String typStromu = "";
		String vybranyTypStromu = String.valueOf(typDrevaSpinner
				.getSelectedItem());

		if (vybranyTypStromu == null
				|| vybranyTypStromu.equals(String.valueOf(""))
				|| vybranyTypStromu.isEmpty()
				|| dlzkaKmena.getText().toString().isEmpty()
				|| sirkaKmena.getText().toString().isEmpty()) {
			Toast.makeText(this, R.string.no_data_for_save_selected,
					Toast.LENGTH_SHORT).show();
			return;
		} else {
			typStromu = Constants.KeyMap.get(vybranyTypStromu);
		}

		if (meranieIdText.getText().toString().isEmpty()) {
			TextView nazov = (TextView) ObjemBezKoryNovy.this
					.findViewById(R.id.meranieNazov);
			TextView odberatel = (TextView) ObjemBezKoryNovy.this
					.findViewById(R.id.meranieOdberatel);
			TextView cisloDokladu = (TextView) ObjemBezKoryNovy.this
					.findViewById(R.id.meranieCisloDokladu);
			Long meranieId = MeraniaDao.vlozMeranie(mDbHelper, nazov.getText()
					.toString(), odberatel.getText().toString(),cisloDokladu.getText().toString());
			meranieIdText.setText(meranieId.toString());
			KmeneDao.vlozKmen(mDbHelper, meranieId, typStromu,
					Double.valueOf(dlzkaKmena.getText().toString()),
					Double.valueOf(sirkaKmena.getText().toString()),
					getResult());
			Toast.makeText(this, R.string.successfully_saved,
					Toast.LENGTH_SHORT).show();			
		} else {
			KmeneDao.vlozKmen(mDbHelper,
					Long.valueOf(meranieIdText.getText().toString()),
					typStromu, Double.valueOf(dlzkaKmena.getText().toString()),
					Double.valueOf(sirkaKmena.getText().toString()),
					getResult());
			Toast.makeText(this, R.string.successfully_saved,
					Toast.LENGTH_SHORT).show();			
		}
		
		clearHodnoty(dlzkaKmena, sirkaKmena);
		
		
		
		//vypocet celkoveho objemu zadanych kmenov
		
		
		//TU MOZE IST metoda pre nacitanie uz ulozenych kmenov prisluchajucich danemu meraniu
		//id merania sa skyva v meranie_id textview
		//reloadKenov();
	}

	private void clearHodnoty(EditText dlzkaKmena, EditText sirkaKmena) {
		dlzkaKmena.setText(String.valueOf(""));
		sirkaKmena.setText(String.valueOf(""));		
	}

	private void initializeDbHelper(Context context) {
		if (this.mDbHelper == null) {
			this.mDbHelper = new DatabaseHelper(context);
		}
	}
	

}
