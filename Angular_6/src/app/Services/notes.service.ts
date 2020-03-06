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

  updateNote(id, title, description, email){
    const params={
      Id: id,
      Title :title,
      Description:description,  
      Email:email
    };
    return this.http.put(environment.Url+'api/updateNotes',params);
  }

  addArchive(id){
    return this.http.put(environment.Url +'api/isArchive?id='+ id ,null);
  }

  removeArchive(id){
    return this.http.put(environment.Url +'api/unArchive?id='+ id ,null);
  }

  addTrash(id){
    return this.http.put(environment.Url +'api/isTrash?id='+ id ,null);
  }

  addColor(id,value){
    const url =environment.Url +'api/color?id='+ id +'&color='+ value;
    console.log(url);
    
    return this.http.put(url,null);
  }

  getNotes(email){
    
    return this.http.get(environment.Url+ 'api/getNotes?email='+email);
  }

  addRemainder(id,remainder){
 return this.http.put(environment.Url+ 'api/setRemainder?id='+id+'&remainder='+remainder, null);
  }

  addCollaborator(senderEmail, data, notesId){
const params={
  "SenderEmail": senderEmail,
   "ReceiverEmail": data.receiverEmail,
   "NotesId":notesId
};
return this.http.post(environment.Url+ 'api/addCollaborator',params);
  }

  getCollaborators(noteId){
    return this.http.get(environment.Url+'api/GetCollaborator?notesId='+noteId);
  }
  removeCollaborator(id){
    return this.http.delete(environment.Url+'api/removeCollaborator?id='+id);
  }

  getArchive(email){
    return this.http.get(environment.Url+'api/getArchive?email='+email);
  }

  getTrash(email){
    return this.http.get(environment.Url+'api/getTrash?email='+email);
  }

  getRemainder(email){
    return this.http.get(environment.Url+'api/getRemainders?email='+email);
  }
}
