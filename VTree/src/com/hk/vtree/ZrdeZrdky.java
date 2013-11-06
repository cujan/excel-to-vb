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
		
		//nastavenie citacov
								
		final EditText editTextIhlZrdky1 = (EditText)findViewById(R.id.editTextIhlZrdky1);
		final TextView textViewIhlZrdky1 = (TextView)findViewById(R.id.textViewIhlZrdky1);
				
		//inicializovany cakac zmeny textu v EditText
		TextWatcher ihlZrdky1Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrdky1.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDKY_1,kusy);
				textViewIhlZrdky1.setText(Double.toString(objem));		
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
		editTextIhlZrdky1.addTextChangedListener(ihlZrdky1Listener);
		
		final EditText editTextIhlZrdky2 = (EditText)findViewById(R.id.editTextIhlZrdky2);
		final TextView textViewIhlZrdky2 = (TextView)findViewById(R.id.textViewIhlZrdky2);
		
		editTextIhlZrdky2.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextIhlZrdky3 = (EditText)findViewById(R.id.editTextIhlZrdky3);
		final TextView textViewIhlZrdky3 = (TextView)findViewById(R.id.textViewIhlZrdky3);
		
		editTextIhlZrdky3.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextIhlZrde1 = (EditText)findViewById(R.id.editTextIhlZrde1);
		final TextView textViewIhlZrde1 = (TextView)findViewById(R.id.textViewIhlZrde1);
		
		editTextIhlZrde1.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextIhlZrde2 = (EditText)findViewById(R.id.editTextIhlZrde2);
		final TextView textViewIhlZrde2 = (TextView)findViewById(R.id.textViewIhlZrde2);
		
		editTextIhlZrde2.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextIhlZrde3 = (EditText)findViewById(R.id.editTextIhlZrde3);
		final TextView textViewIhlZrde3 = (TextView)findViewById(R.id.textViewIhlZrde3);
		
		editTextIhlZrde3.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextIhlZrde4 = (EditText)findViewById(R.id.editTextIhlZrde4);
		final TextView textViewIhlZrde4 = (TextView)findViewById(R.id.textViewIhlZrde4);
		
		editTextIhlZrde4.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrdky1 = (EditText)findViewById(R.id.editTextListZrdky1);
		final TextView textViewListZrdky1 = (TextView)findViewById(R.id.textViewListZrdky1);
		
		editTextListZrdky1.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrdky2 = (EditText)findViewById(R.id.editTextListZrdky2);
		final TextView textViewListZrdky2 = (TextView)findViewById(R.id.textViewListZrdky2);
		
		editTextListZrdky2.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrdky3 = (EditText)findViewById(R.id.editTextListZrdky3);
		final TextView textViewListZrdky3 = (TextView)findViewById(R.id.textViewListZrdky3);
		
		editTextListZrdky3.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrde1 = (EditText)findViewById(R.id.editTextListZrde1);
		final TextView textViewListZrde1 = (TextView)findViewById(R.id.textViewListZrde1);
		
		editTextListZrde1.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrde2 = (EditText)findViewById(R.id.editTextListZrde2);
		final TextView textViewListZrde2 = (TextView)findViewById(R.id.textViewListZrde2);
		
		editTextListZrde2.addTextChangedListener(cakacZmenyTextu);
		
		final EditText editTextListZrde3 = (EditText)findViewById(R.id.editTextListZrde3);
		final TextView textViewListZrde3 = (TextView)findViewById(R.id.textViewListZrde3);
		
		editTextListZrde3.addTextChangedListener(cakacZmenyTextu);
		
		
		
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
