import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NotesService {
  archive: any;
  color: any;
  remainder: any;

  constructor(
    private http: HttpClient) { }

    sendData(archive, color,remainder){
      this.archive=archive;
      this.color = color;
      this.remainder = remainder;

    }
  addNote(title, description, email){
    const params={
      Title :title,
      Description : description,
      Email : email,
      Color : this.color,
      Archive : this.archive,
      Remainder : this.remainder
    };
   return this.http.post(environment.Url +'api/addNotes', params);
  }

  updateNote(id, title, description, email) {
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
    return this.http.put(url,null);
  }
  pinNote(id){
     return this.http.put(environment.Url+'api/IsPin?id='+id,null);
  }
  unpinNote(id){
    return this.http.put(environment.Url+'api/UnPin?id='+id,null);
  }
  getNotes(email){
    
    return this.http.get(environment.Url+ 'api/getNotes?email='+email);
  }
  getNotesList(){
    return this.http.get(environment.Url+ 'api/getList');
  }

  addRemainder(id,remainder){
 return this.http.put(environment.Url+ 'api/setRemainder?id='+id+'&remainder='+remainder, null);
  }
  removeRemainder(id){
    return this.http.put(environment.Url+ 'api/removeRemainder?id='+id, null);
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

  delete(id){
    return this.http.delete(environment.Url+'api/removeNotes?id='+id);
  }
  restore(id){
    return this.http.put(environment.Url+'api/restore?id='+id, null);
  }

  deleteAll(email){
    return this.http.delete(environment.Url+'api/deleteAll?email='+email);
  }
  restoreAll(email){
    return this.http.put(environment.Url+'api/restoreAll?email='+email, null);
  }

  addImage(id,file: any ){
    let input = new FormData();
     input.append("image", file);

  return this.http.put(environment.Url + 'api/image?id=' + id, input);
  }

  getLabel(email){
    return this.http.get(environment.Url+'api/getLabel?email='+email);
  }

  removeLabel(id){
    return this.http.delete(environment.Url+'api/deleteLabel?id='+id);
  }
  removeLabell(id){
    return this.http.put(environment.Url+'api/removeLabel?id='+id, null);
  }
  addLabel(email,label,notesId){
    const params={
      "Email": email,
       "Label": label,
       "NotesId":notesId
    };
    return this.http.post(environment.Url+'api/addLabel',params);
  }

  createLabel(email,label){
    const params={
      "Email": email,
       "Label": label
    };
    return this.http.post(environment.Url+'api/addLabel',params);
  }

  updateLabel(id,newLabel){
    const params={
      "Id":id,
       "Label": newLabel
    };
    return this.http .put(environment.Url+'api/updateLabel',params);
  }

}