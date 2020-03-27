import { Component, Injector } from '@angular/core';
import { MatDialog } from '@angular/material';
import { finalize } from 'rxjs/operators';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
    PagedListingComponentBase,
    PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
    ProductsServiceProxy,
    ProductDto,
    ProductDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateProductDialogComponent } from './create-product/create-product-dialog.component';
import { EditProductDialogComponent }   from './edit-product/edit-product-dialog.component';

class PagedProductsRequestDto extends PagedRequestDto {
    keyword: string;
}

@Component({
    templateUrl: './products.component.html',
    animations: [appModuleAnimation()],
    styles: [
        `
          mat-form-field {
            padding: 10px;
          }
        `
    ]
})
export class ProductsComponent extends PagedListingComponentBase<ProductDto> {
    products: ProductDto[] = [];

    keyword = '';

    constructor(
        injector: Injector,
        private _productsService: ProductsServiceProxy,
        private _dialog: MatDialog
    ) {
        super(injector);
    }

    list(
        request: PagedProductsRequestDto,
        pageNumber: number,
        finishedCallback: Function
    ): void {

        request.keyword = this.keyword;

        this._productsService
            .getAll(request.keyword, request.skipCount, request.maxResultCount)
            .pipe(
                finalize(() => {
                    finishedCallback();
                })
            )
            .subscribe((result: ProductDtoPagedResultDto) => {
                this.products = result.items;
                this.showPaging(result, pageNumber);
            });
    }

    delete(product: ProductDto): void {
        abp.message.confirm(
            this.l('productDeleteWarningMessage', product.name),
            undefined,
            (result: boolean) => {
                if (result) {
                    this._productsService
                        .delete(product.id)
                        .pipe(
                            finalize(() => {
                                abp.notify.success(this.l('SuccessfullyDeleted'));
                                this.refresh();
                            })
                        )
                        .subscribe(() => { });
                }
            }
        );
    }

    createProduct(): void {
        this.showCreateOrEditproductDialog();
    }

    editProduct(product: ProductDto): void {
        this.showCreateOrEditproductDialog(product.id);
    }

    showCreateOrEditproductDialog(id?: number): void {
        let createOrEditproductDialog;
        if (id === undefined || id <= 0) {
            createOrEditproductDialog = this._dialog.open(CreateProductDialogComponent);
        } else {
            createOrEditproductDialog = this._dialog.open(EditProductDialogComponent, {
                data: id
            });
        }

        createOrEditproductDialog.afterClosed().subscribe(result => {
            if (result) {
                this.refresh();
            }
        });
    }
}
