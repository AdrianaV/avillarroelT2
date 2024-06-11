namespace avillarroelT2.Views;

public partial class vprincipal : ContentPage
{
	public vprincipal()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        //Validación no vacio o null
        if (pkEstudiantes.SelectedIndex == -1) {
            DisplayAlert("Error", "Es obligatorio seleccionar un estudiante.", "Cancelar");
            return;
        }
        if (string.IsNullOrEmpty(txtDato11.Text)) {
            DisplayAlert("Error", "Es obligatorio ingresar nota de seguimiento 1.", "Cancelar");
            return;
        }
        if (decimal.TryParse(txtDato11.Text, out decimal d11)) {
            if (d11 <= 0.1m || d11 >= 10m) {
                DisplayAlert("Error", "Nota de seguimiento 1 debe estar entre 0.1 - 10.", "Cancelar");
                return;
            }
        } else {
            DisplayAlert("Error", "Salario debe ser números válidos.", "Cancelar");
            return;
        }
        if (string.IsNullOrEmpty(txtDato12.Text)) {
            DisplayAlert("Error", "Es obligatorio ingresar nota de examen 1.", "Cancelar");
            return;
        }
        if (decimal.TryParse(txtDato12.Text, out decimal d12)) {
            if (d12 <= 0.1m || d12 >= 10m) {
                DisplayAlert("Error", "Nota de examen 1 debe estar entre 0.1 - 10.", "Cancelar");
                return;
            }
        } else {
            DisplayAlert("Error", "Salario debe ser números válidos.", "Cancelar");
            return;
        }
        if (string.IsNullOrEmpty(txtDato21.Text)) {
            DisplayAlert("Error", "Es obligatorio ingresar nota de seguimiento 1.", "Cancelar");
            return;
        }
        if (decimal.TryParse(txtDato21.Text, out decimal d21)) {
            if (d21 <= 0.1m || d21 >= 10m) {
                DisplayAlert("Error", "Nota de seguimiento 2 debe estar entre 0.1 - 10.", "Cancelar");
                return;
            }
        } else {
            DisplayAlert("Error", "Salario debe ser números válidos.", "Cancelar");
            return;
        }
        if (string.IsNullOrEmpty(txtDato22.Text)) {
            DisplayAlert("Error", "Es obligatorio ingresar nota de examen 2.", "Cancelar");
            return;
        }
        if (string.IsNullOrEmpty(txtDato21.Text)) {
            DisplayAlert("Error", "Es obligatorio ingresar nota de seguimiento 1.", "Cancelar");
            return;
        }
        if (decimal.TryParse(txtDato22.Text, out decimal d22)) {
            if (d22 <= 0.1m || d22 >= 10m) {
                DisplayAlert("Error", "Nota de exmamen 2 debe estar entre 0.1 - 10.", "Cancelar");
                return;
            }
        } else {
            DisplayAlert("Error", "Salario debe ser números válidos.", "Cancelar");
            return;
        }

        String nombre = pkEstudiantes.SelectedItem.ToString();
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");

        double dato11 = Convert.ToDouble(txtDato11.Text);
        double dato12 = Convert.ToDouble(txtDato12.Text);
        double parcial1 = Math.Round((dato11 * 0.3) + (dato12 * 0.2),2);


        double dato21 = Convert.ToDouble(txtDato21.Text);
        double dato22 = Convert.ToDouble(txtDato22.Text);
        double parcial2 = Math.Round((dato21 * 0.3) + (dato22 * 0.2),2);

        double total = Math.Round((parcial1 + parcial2),2);

        String estado = "";
        if (total >= 7)
        {
            estado = "Aprobado";
        }
        else if (total >= 5 && total <= 6.9)
        {
            estado = "Complementario";
        }
        else if (total < 5)
        {
            estado = "Reprobado";
        }
        else
        {
            estado = "Nota inválida";
        }

        DisplayAlert("Cálculo de calificaciones", "Nombre:  " + nombre  + 
            " \nFecha: " + fecha +
            " \nNota Parcial 1: " + parcial1 +
            " \nNota Parcial 2: " + parcial2 +
            " \nNota Final: " + total +
            " \nEstado: " + estado, "Cancelar");
    }
}




