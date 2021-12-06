import axios, { AxiosInstance, AxiosResponse } from "axios";

export class UserService {
    _axios: AxiosInstance;

    constructor() {
        this._axios = axios.create();
    }

    async get(): Promise<AxiosResponse> {
        const resp = await this._axios.get("http://localhost:3000/api/users");
        return resp.data;
    }

}