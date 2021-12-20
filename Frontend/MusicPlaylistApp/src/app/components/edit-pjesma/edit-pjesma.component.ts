import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { PjesmaDTO } from 'src/app/models/PjesmaDTO';
import { PjesmaService } from 'src/app/services/pjesma.service';
import { ActivatedRoute, Router } from '@angular/router';
import { DataSharingService } from 'src/app/services/data-sharing.service';

@Component({
  selector: 'app-edit-pjesma',
  templateUrl: './edit-pjesma.component.html',
  styleUrls: ['./edit-pjesma.component.css'],
})
export class EditPjesmaComponent implements OnInit {
  data: PjesmaDTO;
  public id!: number;
  constructor(
    private pjesmaService: PjesmaService,
    private route: ActivatedRoute,
    private router: Router,
    private dataSharing: DataSharingService
  ) {
    this.data = new PjesmaDTO();
  }

  ngOnInit(): void {
    this.id = parseInt(this.route.snapshot.paramMap.get('id')!);
    this.pjesmaService.getPjesmaById(this.id).subscribe((data) => {
      this.data = data;
    });
  }

  onEditPjesma(): void {
    
    this.router.navigateByUrl('/pjesme');
    this.dataSharing.editPjesma.next(this.data);
  }
}
