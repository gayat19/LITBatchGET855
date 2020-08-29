export class Movie{
    id:number;
    name:string;
    duration:number;
    constructor(id?,name?,duration?){
        this.name = name;
        this.id=id;
        this.duration = duration;
    }
}