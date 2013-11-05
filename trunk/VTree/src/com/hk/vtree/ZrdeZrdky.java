package com.hk.vtree;

import android.os.Bundle;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class ZrdeZrdky extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_zrde_zrdky);
		
		//nacitanie EditText do premennych
		final EditText editTextIhlZrdky1 = (EditText)findViewById(R.id.editTextIhlZrdky1);
		EditText editTextIhlZrdky2 = (EditText)findViewById(R.id.editTextIhlZrdky2);
		EditText editTextIhlZrdky3 = (EditText)findViewById(R.id.editTextIhlZrdky3);
		EditText editTextIhlZrde1 = (EditText)findViewById(R.id.editTextIhlZrde1);
		EditText editTextIhlZrde2 = (EditText)findViewById(R.id.editTextIhlZrde2);
		EditText editTextIhlZrde3 = (EditText)findViewById(R.id.editTextIhlZrde3);
		EditText editTextIhlZrde4 = (EditText)findViewById(R.id.editTextIhlZrde4);
		EditText editTextListZrdky1 = (EditText)findViewById(R.id.editTextListZrdky1);
		EditText editTextListZrdky2 = (EditText)findViewById(R.id.editTextListZrdky2);
		EditText editTextListZrdky3 = (EditText)findViewById(R.id.editTextListZrdky3);
		EditText editTextListZrde1 = (EditText)findViewById(R.id.editTextListZrde1);
		EditText editTextListZrde2 = (EditText)findViewById(R.id.editTextListZrde2);
		EditText editTextListZrde3 = (EditText)findViewById(R.id.editTextListZrde3);
		
		final TextView textViewIhlZrdky1 = (TextView)findViewById(R.id.textViewIhlZrdky1);
				
		
		//inicializovany cakac zmeny textu v EditText
		TextWatcher ihlZrdky1Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				
				String objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDKY_1,editTextIhlZrdky1.getText().toString());
				textViewIhlZrdky1.setText(objem);		
			}
			
			@Override
			public void beforeTextChanged(CharSequence s, int start, int count,
					int after) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void afterTextChanged(Editable s) {
				// TODO Auto-generated method stub
				
			}
		};
		//nastavenie cakaca na jednotlice EditText
		editTextIhlZrdky1.addTextChangedListener(ihlZrdky1Listener);
		//editTextIhlZrdky2.addTextChangedListener(cakacZmenyTextu);
		//editTextIhlZrdky3.addTextChangedListener(cakacZmenyTextu);
		//editTextIhlZrde1.addTextChangedListener(cakacZmenyTextu);
		//editTextIhlZrde2.addTextChangedListener(cakacZmenyTextu);
		//editTextIhlZrde3.addTextChangedListener(cakacZmenyTextu);
		//editTextIhlZrde4.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrdky1.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrdky2.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrdky3.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrde1.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrde2.addTextChangedListener(cakacZmenyTextu);
		//editTextListZrde3.addTextChangedListener(cakacZmenyTextu);
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.zrde_zrdky, menu);
		return true;
	}
	
	
	public void onClickButtonPokus( View v){
		
		TextView objemik = (TextView) findViewById(R.id.textViewIhlZrde1);
		objemik.setText(vypocty.tester());
		//Toast.makeText(this, "pokus - tester",Toast.LENGTH_LONG).show();
		
		
		
	}
	
	
	
	

}
