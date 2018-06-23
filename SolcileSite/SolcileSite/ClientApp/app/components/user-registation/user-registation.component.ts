import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../services/make.service';
//import { FeatureService } from '../../services/feature.service';

@Component({
  selector: 'app-user-registation',
  templateUrl: './user-registation.component.html',
  styleUrls: ['./user-registation.component.css']
})
export class UserRegistationComponent implements OnInit {
    makes;
    models;
    feature;
    //tscongig iadd this flase so i don ot need to write  make: any[];"noImplicitAny": false,
    vechile : any = {};
    ///i sould set
    //"noImplicitAny": false, in ts config otherwise it will not work
    //////constructor(private makeServie: MakeService, private FeatureService: FeatureService) { }
    constructor(private makeServie: MakeService) { }

    ngOnInit() {
        this.makeServie.getMake().subscribe(makes =>
            this.makes = makes);
            //checking the value is comming or not console.log("makeesbal", this.makes); );

        this.makeServie.getFeature().subscribe(feature => {
            this.feature = feature;
            console.log(this.feature)
        //this.FeatureService.getFeature().subscribe(feature => {
        //this.feature = feature;
        //    console.log(this.feature)
        });
        
       
    }
    onMakeChange() {
        //console.log("Vechile", this.vechile); check it workor not
        var selectedmake = this.makes.find(m => m.id == this.vechile.make);
        this.models = selectedmake ?selectedmake.models:[] ;

    }

}
