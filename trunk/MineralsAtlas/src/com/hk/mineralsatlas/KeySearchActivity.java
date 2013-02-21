package com.hk.mineralsatlas;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class KeySearchActivity extends FragmentActivity {

	private static String URL = "";

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.key_search);
		URL = getIntent().getStringExtra(Constants.EXTRA_URL);
	}

	public void onSearchClicked(View v) {
		Spinner shape = (Spinner) findViewById(R.id.shape_id);
		Spinner color = (Spinner) findViewById(R.id.color_id);
		Spinner vryp = (Spinner) findViewById(R.id.vryp_id);
		Spinner lesk = (Spinner) findViewById(R.id.lesk_id);
		Spinner light = (Spinner) findViewById(R.id.light_id);
		EditText hardnessFrom = (EditText) findViewById(R.id.hardness_from_id);
		EditText hardnessTo = (EditText) findViewById(R.id.hardness_to_id);

		String shapeAs = String.valueOf(shape.getSelectedItem());
		String colorAs = String.valueOf(color.getSelectedItem());
		String vrypAs = String.valueOf(vryp.getSelectedItem());
		String leskAs = String.valueOf(lesk.getSelectedItem());
		String lightAs = String.valueOf(light.getSelectedItem());
		String hardnessFromAs = hardnessFrom.getText().toString();
		String hardnessToAs = hardnessTo.getText().toString();
		boolean notComplete = false;
		String text = "Vyberte hodnotu: \n";
		String extraPath = "";
		
		if (shapeAs == null || shapeAs.equals(String.valueOf(""))) {
			text += "\t" + shape.getPrompt().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="tvar="+Constants.KeyMap.get(shapeAs)+"&" ;
		}

		if (colorAs == null || colorAs.equals(String.valueOf(""))) {
			text += "\t" + color.getPrompt().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="farba="+Constants.KeyMap.get(colorAs)+"&" ;
		}

		if (vrypAs == null || vrypAs.equals(String.valueOf(""))) {
			text += "\t" + vryp.getPrompt().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="vryp="+Constants.KeyMap.get(shapeAs)+"&" ;
		}

		if (leskAs == null || leskAs.equals(String.valueOf(""))) {
			text += "\t" + lesk.getPrompt().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="lesk="+Constants.KeyMap.get(leskAs)+"&" ;
		}

		if (lightAs == null || lightAs.equals(String.valueOf(""))) {
			text += "\t" + light.getPrompt().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="svetlo="+Constants.KeyMap.get(lightAs)+"&" ;
		}

		if (hardnessFromAs == null || hardnessFromAs.equals(String.valueOf(""))) {
			text += "\t" + hardnessFrom.getHint().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="tvrdostod="+hardnessFromAs+"&" ;
		}

		if (hardnessToAs == null || hardnessToAs.equals(String.valueOf(""))) {
			text += "\t" + hardnessTo.getHint().toString() + "\n";
			notComplete = true;
		} else {
			extraPath +="tvrdostdo="+hardnessToAs ;
		}

		if (notComplete) {

			Toast.makeText(this, text, Toast.LENGTH_LONG).show();
			return;
		}

		Toast.makeText(this, URL+Constants.ACTION_MINERALS_SEARCH+extraPath, Toast.LENGTH_LONG).show();
		
		Intent i = new Intent(KeySearchActivity.this,
				ShowMineralsListActivity.class);
		i.putExtra(Constants.EXTRA_URL, URL);
		i.putExtra(Constants.EXTRA_PATH, Constants.ACTION_MINERALS_SEARCH+extraPath);
		i.putExtra(Constants.EXTRA_ACTION, Constants.MINERALS_LIST);
		startActivity(i);

	}

}
