import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'NTKEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44339/',
    redirectUri: baseUrl,
    clientId: 'NTKEcommerce_App',
    responseType: 'code',
    scope: 'offline_access NYKEcommerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44351',
      rootNamespace: 'NTKEcommerce',
    },
  },
} as Environment;
