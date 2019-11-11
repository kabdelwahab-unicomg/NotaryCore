import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-notary-search',
    templateUrl: './notary-search.component.html',
    styleUrls: ['./notary-search.component.scss']
})
/** NotarySearch component*/
export class NotarySearchComponent {
    public searchResult: boolean;
    public httpVar: HttpClient;    
    
    constructor(http: HttpClient) {
        this.httpVar = http;        
    }
    getSearch(searchId: number) {
        
        this.httpVar.get<boolean>('http://localhost:50177/api/Search/' + searchId).subscribe(result => {
            this.searchResult = result;
        }, error => console.error(error));        
    }
}
