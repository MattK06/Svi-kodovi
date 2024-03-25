package com.example.a12022024;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.DialogInterface;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    int broj=0;
    boolean odabrano[] = {true, false, true};
    final CharSequence poljeNazivi[] = { "-1", "+1", "+2" };

    int sel=0;
    final CharSequence poljeNazivi2[] = { "-1", "+1", "+2" };

    public void tipkaPritisnuta1(View view) {
        TextView textview1 = (TextView) findViewById(R.id.textView);
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setItems(R.array.odabir_boja, new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {
                switch (which) {
                    case 0:
                        broj--;
                        textview1.setText("" + broj);
                        break;
                    case 1:
                        broj++;
                        textview1.setText("" + broj);
                        break;
                    case 2:
                        broj=broj+2;
                        textview1.setText("" + broj);
                }
            }
        });
        builder.show();
    }
    public void tipkaPritisnuta2(View view) {
        TextView textview1 = (TextView) findViewById(R.id.textView);
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Odaberi:");

        builder.setSingleChoiceItems(poljeNazivi2, sel, new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {
                sel=id;
            }});
        builder.setPositiveButton("Fire", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {
                broj = broj + Integer.parseInt(poljeNazivi2[sel].toString());
                textview1.setText("" + broj);
            }
        });
        builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {

            }
        });
        builder.show();
    }

    public void tipkaPritisnuta3(View view) {
        TextView textview1 = (TextView) findViewById(R.id.textView);
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Odaberi:");

        builder.setMultiChoiceItems(poljeNazivi, odabrano, new DialogInterface.OnMultiChoiceClickListener() {
            public void onClick(DialogInterface dialog, int id, boolean b) {

            }
        });
        builder.setPositiveButton("Fire", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {
                if(odabrano[0]==true){
                    broj=broj-1;
                    textview1.setText("" + broj);
                }
                if(odabrano[1]==true){
                    broj=broj+1;
                    textview1.setText("" + broj);
                }
                if(odabrano[2]==true){
                    broj=broj+2;
                    textview1.setText("" + broj);
                }
            }
        });
        builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int id) {
            }
        });
        builder.show();
    }


}
