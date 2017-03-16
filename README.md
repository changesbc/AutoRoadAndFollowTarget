# AutoRoadAndFollowTarget
### 相机的跟随
###### 调整好相机和小球的位置，选择相机，然后GameObject->Align with view。首先将相机放置到小球下成为其子物体，
###### 由于小球放大了两倍，所以相机的便宜位置offset发大2倍，最后将相机从小球的下面移出。
******
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/11.PNG)
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/12.PNG)
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/GIF.gif)

### 自动寻路(鼠标左键按下开始自动寻路)
* 选中Colider中所有Cube，并点击Static
* 选中Window->Navigation->Bake
* 给小球添加NavMeshAgent组件
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/13.PNG)
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/14.PNG)
![image](https://github.com/Changesbc/AutoRoadAndFollowTarget/raw/master/Images/AutoMove.gif)
