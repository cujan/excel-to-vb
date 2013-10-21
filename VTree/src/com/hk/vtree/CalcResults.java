package com.hk.vtree;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;

public class CalcResults extends Activity {
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.calc_result);

		Double calcVolume = getIntent().getDoubleExtra(Constants.VOLUME_RESULT,
				0);
		//TextView volume = (TextView) findViewById(R.id.textView1);
		//volume.setText(calcVolume.toString());

	}
}
