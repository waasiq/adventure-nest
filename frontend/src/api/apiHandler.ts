import axios, { AxiosRequestConfig, AxiosResponse } from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:7052/api',
  headers: {
    'Content-Type': 'application/json',
    'Authorization': 'bearer ' + localStorage.getItem('token'),
  },
});

export async function getAPIHandler<T>(url: string, params?: string, config?: AxiosRequestConfig): Promise<AxiosResponse<T>> {
  const response = await api.get<T>(url, { params, ...config });
  return response;
}

export async function postAPIHandler<T>(url: string, data: any, config?: AxiosRequestConfig): Promise<AxiosResponse<T>> {
    const response = await api.post<T>(url, data, config);
    return response;
}

export async function putAPIHandler<T>(url: string, data: any, config?: AxiosRequestConfig): Promise<AxiosResponse<T>> {
    const response = await api.put<T>(url, data, config);
    return response;
}

export async function deleteAPIHandler<T>(url: string, config?: AxiosRequestConfig): Promise<AxiosResponse<T>> {
    const response = await api.delete<T>(url, config);
    return response;
}