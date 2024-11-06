import { Routes } from "@angular/router";

export const authenticationRoutes: Routes = [
    {
        path: "auth",
        loadComponent: () => import("./pages/authentication/authentication.component").then(m => m.AuthenticationComponent),
    }
];
