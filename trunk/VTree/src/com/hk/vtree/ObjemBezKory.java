package com.hk.vtree;

import java.security.PublicKey;

import android.os.Bundle;
import android.app.Activity;
import android.view.*;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.text.*;

public class ObjemBezKory extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_objem_bez_kory);
		
		
	}
	
	public void onClickVypocitajObjemKmena(View v){
		
		TextView vysledok = (TextView)findViewById(R.id.textViewVysledok);
		Spinner typDrevaSpinner = (Spinner)findViewById(R.id.spinnerTypDreva);
		EditText dlzkaKmena = (EditText)findViewById(R.id.editTextDlzkaKmena);
		EditText sirkaKmena = (EditText)findViewById(R.id.editTextSirkaKmena);
		
		String typStromu = "";
		
		String vybranyTypStromu = String.valueOf(typDrevaSpinner.getSelectedItem());
		
		if (vybranyTypStromu == null || vybranyTypStromu.equals(String.valueOf(""))
			|| vybranyTypStromu.isEmpty()) {
		Toast.makeText(this, R.string.no_tree_type_selected,
			Toast.LENGTH_SHORT).show();
		return;
		} else {
		typStromu = Constants.KeyMap.get(vybranyTypStromu);
		}
		
		//kontrola ci je vlozena dlzka - dokoncit
		
		
		
		
			vysledok.setText(getResult());
		
		
		
		
		
		
	}
	
	public String getResult(){
		EditText dlzkaKmena = (EditText)findViewById(R.id.editTextDlzkaKmena);
		EditText sirkaKmena = (EditText)findViewById(R.id.editTextSirkaKmena);
		Double dlzka = Double.valueOf(dlzkaKmena.getText().toString());
		Double sirka = Double.valueOf(sirkaKmena.getText().toString());
		
		String result;
		
		
		
		
		Double objem;
		Double hrubkaKory = koeficient();
		
		objem = (Math.PI*dlzka*Math.pow((sirka - hrubkaKory),2))/40000;
		//DecimalFormat f = new DecimalFormat("##.00");
		//f.format(objem); 
		double zaokruhlene = Math.round(objem*100)/100D;
		
		
		result = zaokruhlene+"m3";
		return result;
	}
	
	public double koeficient(){
		EditText sirkaKmena = (EditText)findViewById(R.id.editTextSirkaKmena);
		//vyber typu stromu a porovnanie a nasledne pouzitie prislusnej konstanty
		
		Spinner typDrevaSpinner = (Spinner)findViewById(R.id.spinnerTypDreva);
		
		String typStromu = "";
		
		String vybranyTypStromu = String.valueOf(typDrevaSpinner.getSelectedItem());
		
		if (vybranyTypStromu == null || vybranyTypStromu.equals(String.valueOf(""))
			|| vybranyTypStromu.isEmpty()) {
		Toast.makeText(this, R.string.no_tree_type_selected,
			Toast.LENGTH_SHORT).show();
		//return;
		} else {
		typStromu = Constants.KeyMap.get(vybranyTypStromu);
		}
		
		Double sirka = Double.valueOf(sirkaKmena.getText().toString());
		double hrubka = 0;
		double p0=0;
		double p1=0;
		double p2=0;
		
		
		if(typStromu=="sm"){
			p0 = Constants.P0SM;
			p1 = Constants.P1SM;
			p2 = Constants.P2SM;
		}else if (typStromu=="db") {
			p0= Constants.P0DB;
			p1= Constants.P1DB;
			p2= Constants.P2DB;
		}else if (typStromu=="bk") {
			p0=Constants.P0BK;
			p1=Constants.P1BK;
			p2=Constants.P2BK;
		}else if (typStromu=="bo") {
			p0=Constants.P0BO;
			p1=Constants.P1BO;
			p2=Constants.P2BO;
		}
		
		
		
		
		
		hrubka =p0 + p1*Math.pow(sirka, p2);
		
		return hrubka;
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.objem_bez_kory, menu);
		return true;
	}

}
