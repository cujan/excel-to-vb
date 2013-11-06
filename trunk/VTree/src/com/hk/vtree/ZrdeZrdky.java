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
				
				if (kusy == 0 || editTextIhlZrdky1.getText().toString().isEmpty()== true){
				
				}else {
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDKY_1,kusy);
				textViewIhlZrdky1.setText(Double.toString(objem));
				}
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
		TextWatcher ihlZrdky2Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrdky2.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDKY_2,kusy);
				textViewIhlZrdky2.setText(Double.toString(objem));		
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
		editTextIhlZrdky2.addTextChangedListener(ihlZrdky2Listener);
		
		final EditText editTextIhlZrdky3 = (EditText)findViewById(R.id.editTextIhlZrdky3);
		final TextView textViewIhlZrdky3 = (TextView)findViewById(R.id.textViewIhlZrdky3);
		TextWatcher ihlZrdky3Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrdky3.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDKY_3,kusy);
				textViewIhlZrdky3.setText(Double.toString(objem));		
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
		editTextIhlZrdky3.addTextChangedListener(ihlZrdky3Listener);
		
		final EditText editTextIhlZrde1 = (EditText)findViewById(R.id.editTextIhlZrde1);
		final TextView textViewIhlZrde1 = (TextView)findViewById(R.id.textViewIhlZrde1);
		TextWatcher ihlZrde1Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrde1.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDE_1,kusy);
				textViewIhlZrde1.setText(Double.toString(objem));		
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
		editTextIhlZrde1.addTextChangedListener(ihlZrde1Listener);
		
		final EditText editTextIhlZrde2 = (EditText)findViewById(R.id.editTextIhlZrde2);
		final TextView textViewIhlZrde2 = (TextView)findViewById(R.id.textViewIhlZrde2);
		TextWatcher ihlZrde2Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrde2.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDE_2,kusy);
				textViewIhlZrde2.setText(Double.toString(objem));		
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
		editTextIhlZrde2.addTextChangedListener(ihlZrde2Listener);
		
		final EditText editTextIhlZrde3 = (EditText)findViewById(R.id.editTextIhlZrde3);
		final TextView textViewIhlZrde3 = (TextView)findViewById(R.id.textViewIhlZrde3);
		TextWatcher ihlZrde3Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrde3.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDE_3,kusy);
				textViewIhlZrde3.setText(Double.toString(objem));		
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
		editTextIhlZrde3.addTextChangedListener(ihlZrde3Listener);
		
		final EditText editTextIhlZrde4 = (EditText)findViewById(R.id.editTextIhlZrde4);
		final TextView textViewIhlZrde4 = (TextView)findViewById(R.id.textViewIhlZrde4);
		TextWatcher ihlZrde4Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextIhlZrde4.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.IHL_ZRDE_4,kusy);
				textViewIhlZrde4.setText(Double.toString(objem));		
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
		editTextIhlZrde4.addTextChangedListener(ihlZrde4Listener);
		
		final EditText editTextListZrdky1 = (EditText)findViewById(R.id.editTextListZrdky1);
		final TextView textViewListZrdky1 = (TextView)findViewById(R.id.textViewListZrdky1);
		TextWatcher listZrdky1Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrdky1.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDKY_1,kusy);
				textViewListZrdky1.setText(Double.toString(objem));		
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
		editTextListZrdky1.addTextChangedListener(listZrdky1Listener);
		
		final EditText editTextListZrdky2 = (EditText)findViewById(R.id.editTextListZrdky2);
		final TextView textViewListZrdky2 = (TextView)findViewById(R.id.textViewListZrdky2);
		TextWatcher listZrdky2Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrdky2.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDKY_2,kusy);
				textViewListZrdky2.setText(Double.toString(objem));		
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
		editTextListZrdky2.addTextChangedListener(listZrdky2Listener);
		
		final EditText editTextListZrdky3 = (EditText)findViewById(R.id.editTextListZrdky3);
		final TextView textViewListZrdky3 = (TextView)findViewById(R.id.textViewListZrdky3);
		TextWatcher listZrdky3Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrdky3.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDKY_3,kusy);
				textViewListZrdky3.setText(Double.toString(objem));		
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
		editTextListZrdky3.addTextChangedListener(listZrdky3Listener);
		
		final EditText editTextListZrde1 = (EditText)findViewById(R.id.editTextListZrde1);
		final TextView textViewListZrde1 = (TextView)findViewById(R.id.textViewListZrde1);
		TextWatcher listZrde1Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrde1.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDE_1,kusy);
				textViewListZrde1.setText(Double.toString(objem));		
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
		editTextListZrde1.addTextChangedListener(listZrde1Listener);
		
		final EditText editTextListZrde2 = (EditText)findViewById(R.id.editTextListZrde2);
		final TextView textViewListZrde2 = (TextView)findViewById(R.id.textViewListZrde2);
		TextWatcher listZrde2Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrde2.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDE_2,kusy);
				textViewListZrde2.setText(Double.toString(objem));		
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
		editTextListZrde2.addTextChangedListener(listZrde2Listener);
		
		final EditText editTextListZrde3 = (EditText)findViewById(R.id.editTextListZrde3);
		final TextView textViewListZrde3 = (TextView)findViewById(R.id.textViewListZrde3);
		TextWatcher listZrde3Listener = new TextWatcher() {
			
			@Override
			public void onTextChanged(CharSequence s, int start, int before, int count) {
				// TODO Auto-generated method stub
				int kusy = Integer.valueOf(editTextListZrde3.getText().toString());
				Double objem = vypocty.getObjemZrdovina(Constants.LIST_ZRDE_3,kusy);
				textViewListZrde3.setText(Double.toString(objem));		
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
		editTextListZrde3.addTextChangedListener(listZrde3Listener);
		
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.zrde_zrdky, menu);
		return true;
	}
	
}
