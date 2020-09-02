import { Component, OnInit, Input } from '@angular/core';
import { Movie } from '../models/movie';

@Component({
  selector: 'app-showmovie',
  templateUrl: './showmovie.component.html',
  styleUrls: ['./showmovie.component.css']
})
export class ShowmovieComponent implements OnInit {

  @Input('myMovie')movie:Movie;
  constructor() { }

  ngOnInit(): void {
  }

}
