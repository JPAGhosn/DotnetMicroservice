import {Route} from '@angular/router';

export const recipeRoute: Route = {
  path: "recipes/:id",
  children: [
    {
      path: ":fileName",
      loadComponent: () =>
        import("./recipe-page.component").then(m => m.RecipePageComponent),
    },
    {
      path: "",
      pathMatch: "full",
      redirectTo: "readme"
    }
  ]
};
