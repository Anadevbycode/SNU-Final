import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { AlunoService } from '../aluno.service';
import { Aluno } from '../aluno.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-aluno-list',
  imports: [CommonModule, MatTableModule],
  templateUrl: './aluno-list.html',
  styleUrl: './aluno-list.css'
})
export class AlunoList {
  private service = inject(AlunoService);
  //alunos: Aluno[] = [];
  alunos$: Observable<Aluno[]> = AlunoService.listar();
  displayedColumns = ['id', 'nome', 'nota'];

  constructor() {
    this.service.listar().subscribe(alunos => {
      this.alunos = alunos;
    });
  }
}
