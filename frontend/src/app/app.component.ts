import { Component, ViewChild, ElementRef } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
  @ViewChild('outerfiles') outerfiles: ElementRef;
  @ViewChild('innerfiles') innerfiles: ElementRef;

  public constructor(private http: HttpClient) {}

  public upload(): void {
    const filesa = this.outerfiles.nativeElement.files;
    const filesb = this.innerfiles.nativeElement.files;

    if (filesa.length === 0 || filesb.length === 0) {
      return;
    }

    const formdataa = new FormData();

    for (let i = 0; i < filesa.length; i++) {
      formdataa.append('files', filesa.item(i));
    }


    for (let i = 0; i < filesb.length; i++) {
      formdataa.append('child[files]', filesb.item(i));
    }

    formdataa.append('age', '100');

    formdataa.append('child[name]', 'Doctor Random');

    console.log(formdataa);

    this.http.post('http://localhost:5000/api/files/111', formdataa)
    .subscribe(res => console.log, error => console.error(error), () => console.log('completed'));
  }
}
