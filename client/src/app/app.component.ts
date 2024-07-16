import { Component } from '@angular/core';
import { RouterOutlet,RouterLink,RouterLinkActive } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { InicioComponent } from './inicio/inicio.component';
import { HabitacionesComponent } from './habitaciones/habitaciones.component';
import { CamasComponent } from './camas/camas.component';
import { PacientesComponent } from './pacientes/pacientes.component';
import { IngresosComponent } from './ingresos/ingresos.component';
import { ExpedientesComponent } from './expedientes/expedientes.component';
import { FooterComponent } from './footer/footer.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive, NavbarComponent,InicioComponent,HabitacionesComponent,CamasComponent,PacientesComponent,IngresosComponent,ExpedientesComponent,FooterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'HospitalManagement';
}
