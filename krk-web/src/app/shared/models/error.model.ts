export interface ErrorModel {
  code: string;
  message: string;
}

export function isErrorModel(model: any) {
  return !!model?.code && !!model?.message;
}
