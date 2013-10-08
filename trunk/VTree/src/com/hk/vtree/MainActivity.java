package com.hk.vtree;

import java.math.BigDecimal;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}

	public void onCalculateClicked(View v) {
		String typStromu = "";
		Spinner typDrevaSpinner = (Spinner) findViewById(R.id.typ_dreva);
		String vybranyTyp = String.valueOf(typDrevaSpinner.getSelectedItem());
		if (vybranyTyp == null || vybranyTyp.equals(String.valueOf(""))
				|| vybranyTyp.isEmpty()) {
			Toast.makeText(this, R.string.no_tree_type_selected,
					Toast.LENGTH_SHORT).show();
			return;
		} else {
			typStromu = Constants.KeyMap.get(vybranyTyp);
		}

		// Potahat dalsie fieldy a ich hodnoty a vypocitat objem (volume) -
		// POUZIT BigDecimal pre realne cisla

		BigDecimal volume = BigDecimal.ONE;
		
		//sendResults(volume);

	}

	public void sendResults(BigDecimal volume) {
		Intent i = new Intent(this, CalcResults.class);
		i.putExtra(Constants.VOLUME_RESULT, volume.doubleValue());
		startActivity(i);
	}

}
