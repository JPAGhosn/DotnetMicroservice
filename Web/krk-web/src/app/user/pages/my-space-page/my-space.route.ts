export const mySpaceRoute = {
  path: 'cooking-lab',
  loadComponent: () => import("./cooking-lab-page.component").then(m => m.CookingLabPageComponent),
};
