import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { identifierModuleUrl } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class NotesService {

  constructor(private http: HttpClient) { }

  addNote(title, description, email){
    const params={
      Title :title,
      Description : description,
      Email : email
    };
   return this.http.post(environment.Url +'api/addNotes', params)
  }

  addArchive(id){
return this.http.put(environment.Url +'api/isArchive?id='+ id ,null);
  }

  addTrash(id){
    return this.http.put(environment.Url +'api/isTrash?id='+ id ,null);
  }

  changeColor(id,value){
    return this.http.put(environment.Url +'api/color?id='+ id +'&color='+ value ,null);
  }

  getNotes(email){
    
    return this.http.get(environment.Url+ 'api/getNotes?email='+email);
  }

  addRemainder(id,remainder){
 return this.http.put(environment.Url+ 'api/setRemainder?id='+id+'&remainder='+remainder, null);
  }
}
