package com.hk.vtree;

import android.os.Bundle;
import android.app.Activity;
import android.view.*;
import android.widget.EditText;
import android.widget.TextView;

public class ObjemBezKory extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_objem_bez_kory);
		
		
	}
	
	public void onClickVypocitajObjemKmena(View v){
		
		TextView vysledok = (TextView)findViewById(R.id.textViewVysledok);
		
		vysledok.setText(getResult());
		
		
	}
	
	public String getResult(){
		EditText dlzkaKmena = (EditText)findViewById(R.id.editTextDlzkaKmena);
		EditText sirkaKmena = (EditText)findViewById(R.id.editTextSirkaKmena);
		String result;
		
		Double dlzka = (double) 2;
		Double sirka = (double) 2;
		Double objem;
		
		objem = dlzka*sirka;
		
		
		
		
		result = objem.toString();
		return result;
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.objem_bez_kory, menu);
		return true;
	}

}
