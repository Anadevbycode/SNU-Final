import { Injectable, inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Aluno } from "./aluno.model";
import { Observable, of } from "rxjs";

@Injectable({ providedIn: 'root' })
export class AlunoService {
  constructor(private http: HttpClient) {}
  private readonly API = 'http://localhost:5223/api/Aluno';
  listar(): Observable<Aluno[]> {
    return this.http.get<Aluno[]>(this.API);
  }
  adicionar(aluno: Omit<Aluno, 'id'>): Observable<Aluno> {
    return this.http.post<Aluno>(this.API, aluno);
  }

}
