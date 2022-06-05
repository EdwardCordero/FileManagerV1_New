import { HttpClient, HttpHeaders, HttpRequest } from '@angular/common/http';
import { Component } from '@angular/core';
import { from, Observable, pipe } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private httpClient: HttpClient) {}

  public onFileSelected(event: any) {
    let file: File;

    file = event.target.files;
     
    var response = this.UploadFile(file)
      .subscribe(response => {
        console.log(response);
      });
  }

  public UploadFile(file: File): Observable<any> {
    const uploadFileUrl = "http://localhost:5200/File/create-file";
    const headers = new HttpHeaders().set('Access-Control-Allow-Origin', '*');
    return this.httpClient.post(uploadFileUrl, file, { headers: headers, withCredentials: true });
  }
}
