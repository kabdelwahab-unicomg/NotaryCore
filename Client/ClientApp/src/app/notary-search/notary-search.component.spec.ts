/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { NotarySearchComponent } from './notary-search.component';

let component: NotarySearchComponent;
let fixture: ComponentFixture<NotarySearchComponent>;

describe('NotarySearch component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ NotarySearchComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(NotarySearchComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});