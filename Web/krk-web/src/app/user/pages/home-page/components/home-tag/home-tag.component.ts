import {Component, inject, Input} from '@angular/core';
import {TagModel} from '../../models/tag.model';
import {TagComponent} from '@shared/components/tag/tag.component';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'krk-home-tag',
  standalone: true,
  imports: [
    TagComponent
  ],
  templateUrl: './home-tag.component.html',
  styleUrl: './home-tag.component.scss'
})
export class HomeTagComponent {
  router = inject(Router);
  route = inject(ActivatedRoute);

  @Input({required: true}) tag!: TagModel | null;

  get tagId() {
    return this.route.snapshot.queryParams['tagId'] ?? '';
  }

  onClick() {
    this.router.navigate([], {
      relativeTo: this.route, // Keeps the current route
      queryParams: {tagId: this.tag?.id ?? ''}, // Sets the new tagId
      queryParamsHandling: 'merge', // Preserves other existing query params
      // Alternatively, use 'preserve' to keep all existing query params and override specified ones
    });
  }
}
