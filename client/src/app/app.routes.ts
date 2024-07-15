import { Routes } from '@angular/router';
import { InicioComponent } from './inicio/inicio.component';
import { HabitacionesComponent } from './habitaciones/habitaciones.component';
import { CamasComponent } from './camas/camas.component';
import { PacientesComponent } from './pacientes/pacientes.component';
import { IngresosComponent } from './ingresos/ingresos.component';
import { ExpedientesComponent } from './expedientes/expedientes.component';

export const routes: Routes = [
    { path: '', redirectTo: '/inicio', pathMatch: 'full' },
    { path: 'inicio', component: InicioComponent },
    { path: 'habitaciones', component: HabitacionesComponent },
    { path: 'camas', component: CamasComponent },
    { path: 'pacientes', component: PacientesComponent },
    { path: 'ingresos', component: IngresosComponent },
    { path: 'expedientes', component: ExpedientesComponent }
];
