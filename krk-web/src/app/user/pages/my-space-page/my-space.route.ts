export const mySpaceRoute = {
  path: 'my-space',
  loadComponent: () => import("../../pages/my-space-page/my-space-page.component").then(m => m.MySpacePageComponent),
};
