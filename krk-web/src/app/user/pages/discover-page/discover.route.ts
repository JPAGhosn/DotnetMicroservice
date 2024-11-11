export const discoverRoute = {
  path: 'discover',
  loadComponent: () => import("../../pages/discover-page/discover-page.component").then(m => m.DiscoverPageComponent),
};
